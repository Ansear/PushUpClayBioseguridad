using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controllers;
public class DepartamentoController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public DepartamentoController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<DepartamentoDto>>> Get()
    {
        var result = await _unitOfWork.Departamentos.GetAllAsync();
        return _mapper.Map<List<DepartamentoDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<DepartamentoDto>> Get(int id)
    {
        var result = await _unitOfWork.Departamentos.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<DepartamentoDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<DepartamentoDto>> Post([FromBody] DepartamentoDto DepartamentoDto)
    {
        var result = _mapper.Map<Departamento>(DepartamentoDto);
        _unitOfWork.Departamentos.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        DepartamentoDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = DepartamentoDto.Id }, DepartamentoDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<DepartamentoDto>> Put(int id, [FromBody] DepartamentoDto DepartamentoDto)
    {
        if (DepartamentoDto == null)
            return BadRequest();
        if (DepartamentoDto.Id == 0)
            DepartamentoDto.Id = id;
        if (DepartamentoDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Departamento>(DepartamentoDto);
        _unitOfWork.Departamentos.Update(result);
        await _unitOfWork.SaveAsync();
        return DepartamentoDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Departamentos.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.Departamentos.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}