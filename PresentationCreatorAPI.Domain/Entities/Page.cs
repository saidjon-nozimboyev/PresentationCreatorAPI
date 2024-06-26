﻿namespace PresentationCreatorAPI.Domain.Entites;

public class Page : BaseEntity
{
    public byte PageNumber { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string ImagesPath { get; set; } = string.Empty;
    public PresentationPageType PageType { get; set; }
    public int PresentationId { get; set; }
    [ForeignKey(nameof(PresentationId))]
    public Presentation Presentation { get; set; } = null!;
}
