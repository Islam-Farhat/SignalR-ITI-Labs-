using lab1.Models;
using Microsoft.AspNetCore.SignalR;
using System;

namespace lab1.Hubs
{
    public class CourseHub:Hub
    {
        private readonly SignalRContext _context;

        public CourseHub(SignalRContext context)
        {
            this._context = context;
        }


        public void sendcourse(Course course)
        {
            Clients.All.SendAsync("newcourse", course);
             
            _context.Courses.Add(course);
            _context.SaveChanges();


        }

    }
}
