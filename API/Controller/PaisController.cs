using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controllers;
public class PaisController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PaisController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<PaisDto>>> Get()
    {
        var result = await _unitOfWork.Paises.GetAllAsync();
        return _mapper.Map<List<PaisDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<PaisDto>> Get(int id)
    {
        var result = await _unitOfWork.Paises.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<PaisDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PaisDto>> Post([FromBody] PaisDto PaisDto)
    {
        var result = _mapper.Map<Pais>(PaisDto);
        _unitOfWork.Paises.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        PaisDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = PaisDto.Id }, PaisDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<PaisDto>> Put(int id, [FromBody] PaisDto PaisDto)
    {
        if (PaisDto == null)
            return BadRequest();
        if (PaisDto.Id == 0)
            PaisDto.Id = id;
        if (PaisDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Pais>(PaisDto);
        _unitOfWork.Paises.Update(result);
        await _unitOfWork.SaveAsync();
        return PaisDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Paises.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.Paises.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}