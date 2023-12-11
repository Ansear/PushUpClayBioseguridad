using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controllers;
public class ProgramacionController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProgramacionController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<ProgramacionDto>>> Get()
    {
        var result = await _unitOfWork.Programacion.GetAllAsync();
        return _mapper.Map<List<ProgramacionDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProgramacionDto>> Get(int id)
    {
        var result = await _unitOfWork.Programacion.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<ProgramacionDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ProgramacionDto>> Post([FromBody] ProgramacionDto ProgramacionDto)
    {
        var result = _mapper.Map<Programacion>(ProgramacionDto);
        _unitOfWork.Programacion.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        ProgramacionDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = ProgramacionDto.Id }, ProgramacionDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProgramacionDto>> Put(int id, [FromBody] ProgramacionDto ProgramacionDto)
    {
        if (ProgramacionDto == null)
            return BadRequest();
        if (ProgramacionDto.Id == 0)
            ProgramacionDto.Id = id;
        if (ProgramacionDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Programacion>(ProgramacionDto);
        _unitOfWork.Programacion.Update(result);
        await _unitOfWork.SaveAsync();
        return ProgramacionDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Programacion.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.Programacion.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}