using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class CiudadController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CiudadController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<CiudadDto>>> Get()
    {
        var result = await _unitOfWork.Ciudades.GetAllAsync();
        return _mapper.Map<List<CiudadDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CiudadDto>> Get(int id)
    {
        var result = await _unitOfWork.Ciudades.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<CiudadDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CiudadDto>> Post([FromBody] CiudadDto CiudadDto)
    {
        var result = _mapper.Map<Ciudad>(CiudadDto);
        _unitOfWork.Ciudades.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        CiudadDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = CiudadDto.Id }, CiudadDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CiudadDto>> Put(int id, [FromBody] CiudadDto CiudadDto)
    {
        if (CiudadDto == null)
            return BadRequest();
        if (CiudadDto.Id == 0)
            CiudadDto.Id = id;
        if (CiudadDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Ciudad>(CiudadDto);
        _unitOfWork.Ciudades.Update(result);
        await _unitOfWork.SaveAsync();
        return CiudadDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.Ciudades.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.Ciudades.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}