using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controllers;
public class TipoDireccionController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public TipoDireccionController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TipoDireccionDto>>> Get()
    {
        var result = await _unitOfWork.TipoDirecciones.GetAllAsync();
        return _mapper.Map<List<TipoDireccionDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TipoDireccionDto>> Get(int id)
    {
        var result = await _unitOfWork.TipoDirecciones.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<TipoDireccionDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TipoDireccionDto>> Post([FromBody] TipoDireccionDto TipoDireccionDto)
    {
        var result = _mapper.Map<Tipodireccion>(TipoDireccionDto);
        _unitOfWork.TipoDirecciones.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        TipoDireccionDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = TipoDireccionDto.Id }, TipoDireccionDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TipoDireccionDto>> Put(int id, [FromBody] TipoDireccionDto TipoDireccionDto)
    {
        if (TipoDireccionDto == null)
            return BadRequest();
        if (TipoDireccionDto.Id == 0)
            TipoDireccionDto.Id = id;
        if (TipoDireccionDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Tipodireccion>(TipoDireccionDto);
        _unitOfWork.TipoDirecciones.Update(result);
        await _unitOfWork.SaveAsync();
        return TipoDireccionDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.TipoDirecciones.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.TipoDirecciones.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}