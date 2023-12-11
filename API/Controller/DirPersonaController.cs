using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controllers;
public class DirPersonaController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DirPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<DirPersonaDto>>> Get()
    {
        var result = await _unitOfWork.DirPersonas.GetAllAsync();
        return _mapper.Map<List<DirPersonaDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<DirPersonaDto>> Get(int id)
    {
        var result = await _unitOfWork.DirPersonas.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<DirPersonaDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<DirPersonaDto>> Post([FromBody] DirPersonaDto DirPersonaDto)
    {
        var result = _mapper.Map<Dirpersona>(DirPersonaDto);
        _unitOfWork.DirPersonas.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        DirPersonaDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = DirPersonaDto.Id }, DirPersonaDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<DirPersonaDto>> Put(int id, [FromBody] DirPersonaDto DirPersonaDto)
    {
        if (DirPersonaDto == null)
            return BadRequest();
        if (DirPersonaDto.Id == 0)
            DirPersonaDto.Id = id;
        if (DirPersonaDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Dirpersona>(DirPersonaDto);
        _unitOfWork.DirPersonas.Update(result);
        await _unitOfWork.SaveAsync();
        return DirPersonaDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.DirPersonas.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.DirPersonas.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}