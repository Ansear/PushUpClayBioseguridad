using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controllers;
public class EstadoController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public EstadoController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<EstadoDto>>> Get()
    {
        var result = await _unitOfWork.Estados.GetAllAsync();
        return _mapper.Map<List<EstadoDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<EstadoDto>> Get(int id)
    {
        var result = await _unitOfWork.Estados.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<EstadoDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EstadoDto>> Post([FromBody] EstadoDto EstadoDto)
    {
        var result = _mapper.Map<Estado>(EstadoDto);
        _unitOfWork.Estados.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        EstadoDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = EstadoDto.Id }, EstadoDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<EstadoDto>> Put(int id, [FromBody] EstadoDto EstadoDto)
    {
        if (EstadoDto == null)
            return BadRequest();
        if (EstadoDto.Id == 0)
            EstadoDto.Id = id;
        if (EstadoDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Estado>(EstadoDto);
        _unitOfWork.Estados.Update(result);
        await _unitOfWork.SaveAsync();
        return EstadoDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Estados.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.Estados.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}