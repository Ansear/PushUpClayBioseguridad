using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class CategoriaPerController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoriaPerController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<CategoriaPerDto>>> Get()
    {
        var result = await _unitOfWork.CategoriaPer.GetAllAsync();
        return _mapper.Map<List<CategoriaPerDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CategoriaPerDto>> Get(int id)
    {
        var result = await _unitOfWork.CategoriaPer.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<CategoriaPerDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CategoriaPerDto>> Post([FromBody] CategoriaPerDto CategoriaPerDto)
    {
        var result = _mapper.Map<Categoriaper>(CategoriaPerDto);
        _unitOfWork.CategoriaPer.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        CategoriaPerDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = CategoriaPerDto.Id }, CategoriaPerDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CategoriaPerDto>> Put(int id, [FromBody] CategoriaPerDto CategoriaPerDto)
    {
        if (CategoriaPerDto == null)
            return BadRequest();
        if (CategoriaPerDto.Id == 0)
            CategoriaPerDto.Id = id;
        if (CategoriaPerDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Categoriaper>(CategoriaPerDto);
        _unitOfWork.CategoriaPer.Update(result);
        await _unitOfWork.SaveAsync();
        return CategoriaPerDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.CategoriaPer.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.CategoriaPer.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}