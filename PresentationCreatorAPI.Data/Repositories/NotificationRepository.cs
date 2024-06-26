﻿using PresentationCreatorAPI.Data;
using PresentationCreatorAPI.Data.Interfaces;

namespace PresentationCreatorAPI.Repositories;
public class NotificationRepository(AppDbContext dbContext) : GenericRepository<Notification>(dbContext), INotificationRepository
{
}
