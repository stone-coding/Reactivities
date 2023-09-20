using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
  
        // when HTTP req comes, ActivitiesController knows where it have to go and see 
        // it need a DataContext context
        public ActivitiesController(DataContext context)//dependency injection : inject DataContext context to ActivitiesController 
        {
            _context = context;

        }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities(){
            return await _context.Activities.ToListAsync();
        }


        [HttpGet("{id}")] //api/activities/fsadasda
        public async Task<ActionResult<Activity>> GetActivity(Guid id){
            return await _context.Activities.FindAsync(id);
        }

        
        
    }
}