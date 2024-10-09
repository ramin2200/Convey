using Convey.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ramin.MicroServices.Catelog.Application.Commands
{
    //[Contract]
    public class AddProductCommand : ICommand
    {
        public string Title { get; set; }

        public AddProductCommand(string title)
        {
            Title = title;
        }

        //public AddResource()
        //{

        //}
    }
}