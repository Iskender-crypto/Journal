using Journal.Domain.Entities;
using Journal.Infrastructure.Ef;
using Microsoft.AspNetCore.Mvc;

namespace Journal.Api.Controllers.Public;

public class SubjectController(DataContext dataContext) : BaseController<Subject>(dataContext);