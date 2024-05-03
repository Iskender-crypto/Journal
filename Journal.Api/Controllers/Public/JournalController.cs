using Journal.Domain.Entities;
using Journal.Infrastructure.Ef;
using Microsoft.AspNetCore.Mvc;

namespace Journal.Api.Controllers.Public;

public class JournalController(DataContext dataContext) : BaseController<Domain.Entities.Journal>(dataContext);