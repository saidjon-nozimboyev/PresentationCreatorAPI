﻿using Application.DTOs.PageDtos;
using PresentationCreatorAPI.Application.DTOs.PresentationDtos;
using PresentationCreatorAPI.Application.presntations.Presentationpresntations;

namespace PresentationCreatorAPI.Application.Interfaces;

public interface IPresentationServise
{
    Task CreateAsync(AddPresentationDto dto, int userId);
    Task UpdateAsync(UpdatePresentationDto dto);
    Task<PageDto> GetByIdAsync(int id);
    Task<List<PresentationDto>> GetAllAsync();
    Task DeleteAsync(int id);
}
