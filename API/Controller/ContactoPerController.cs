using API.Controller;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class ContactoPerController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ContactoPerController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<ContactoPerDto>>> Get()
    {
        var result = await _unitOfWork.ContactoPer.GetAllAsync();
        return _mapper.Map<List<ContactoPerDto>>(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ContactoPerDto>> Get(int id)
    {
        var result = await _unitOfWork.ContactoPer.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        return _mapper.Map<ContactoPerDto>(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<ContactoPerDto>> Post([FromBody] ContactoPerDto ContactoPerDto)
    {
        var result = _mapper.Map<Contactoper>(ContactoPerDto);
        _unitOfWork.ContactoPer.Add(result);
        await _unitOfWork.SaveAsync();
        if (result == null)
            return BadRequest();
        ContactoPerDto.Id = result.Id;
        return CreatedAtAction(nameof(Post), new { Id = ContactoPerDto.Id }, ContactoPerDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ContactoPerDto>> Put(int id, [FromBody] ContactoPerDto ContactoPerDto)
    {
        if (ContactoPerDto == null)
            return BadRequest();
        if (ContactoPerDto.Id == 0)
            ContactoPerDto.Id = id;
        if (ContactoPerDto.Id != id)
            return NotFound();
        var result = _mapper.Map<Contactoper>(ContactoPerDto);
        _unitOfWork.ContactoPer.Update(result);
        await _unitOfWork.SaveAsync();
        return ContactoPerDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _unitOfWork.ContactoPer.GetByIdAsync(id);
        if (result == null)
            return NotFound();
        _unitOfWork.ContactoPer.Remove(result);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}