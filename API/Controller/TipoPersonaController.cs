using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controllers;
public class TipoPersonaController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public TipoPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TipoPersonaDto>>> Get()
    {
        var result = await _unitOfWork.TipoPersonas.GetAllAsync();
        return _mapper.Map<List<TipoPersonaDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TipoPersonaDto>> Get(int id)
    {
        var result = await _unitOfWork.TipoPersonas.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<TipoPersonaDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TipoPersonaDto>> Post([FromBody] TipoPersonaDto TipoPersonaDto)
    {
        var result = _mapper.Map<Tipopersona>(TipoPersonaDto);
        _unitOfWork.TipoPersonas.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        TipoPersonaDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = TipoPersonaDto.Id }, TipoPersonaDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TipoPersonaDto>> Put(int id, [FromBody] TipoPersonaDto TipoPersonaDto)
    {
        if (TipoPersonaDto == null)
            return BadRequest();
        if (TipoPersonaDto.Id == 0)
            TipoPersonaDto.Id = id;
        if (TipoPersonaDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Tipopersona>(TipoPersonaDto);
        _unitOfWork.TipoPersonas.Update(result);
        await _unitOfWork.SaveAsync();
        return TipoPersonaDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.TipoPersonas.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.TipoPersonas.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}