using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class ContratoController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ContratoController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<ContratoDto>>> Get()
    {
        var result = await _unitOfWork.Contratos.GetAllAsync();
        return _mapper.Map<List<ContratoDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ContratoDto>> Get(int id)
    {
        var result = await _unitOfWork.Contratos.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<ContratoDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ContratoDto>> Post([FromBody] ContratoDto ContratoDto)
    {
        var result = _mapper.Map<Contrato>(ContratoDto);
        _unitOfWork.Contratos.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        ContratoDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = ContratoDto.Id }, ContratoDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ContratoDto>> Put(int id, [FromBody] ContratoDto ContratoDto)
    {
        if (ContratoDto == null)
            return BadRequest();
        if (ContratoDto.Id == 0)
            ContratoDto.Id = id;
        if (ContratoDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Contrato>(ContratoDto);
        _unitOfWork.Contratos.Update(result);
        await _unitOfWork.SaveAsync();
        return ContratoDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Contratos.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.Contratos.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}