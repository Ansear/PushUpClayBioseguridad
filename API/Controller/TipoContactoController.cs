using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controllers;
public class TipoContactoController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public TipoContactoController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TipoContactoDto>>> Get()
    {
        var result = await _unitOfWork.TipoContactos.GetAllAsync();
        return _mapper.Map<List<TipoContactoDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TipoContactoDto>> Get(int id)
    {
        var result = await _unitOfWork.TipoContactos.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<TipoContactoDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TipoContactoDto>> Post([FromBody] TipoContactoDto TipoContactoDto)
    {
        var result = _mapper.Map<Tipocontacto>(TipoContactoDto);
        _unitOfWork.TipoContactos.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        TipoContactoDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = TipoContactoDto.Id }, TipoContactoDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TipoContactoDto>> Put(int id, [FromBody] TipoContactoDto TipoContactoDto)
    {
        if (TipoContactoDto == null)
            return BadRequest();
        if (TipoContactoDto.Id == 0)
            TipoContactoDto.Id = id;
        if (TipoContactoDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Tipocontacto>(TipoContactoDto);
        _unitOfWork.TipoContactos.Update(result);
        await _unitOfWork.SaveAsync();
        return TipoContactoDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.TipoContactos.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.TipoContactos.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}