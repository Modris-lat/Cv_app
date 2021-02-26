using System;
using System.Collections.Generic;
using System.Text;
using Cv_App.Core.Interfaces;

namespace Cv_App.Core.Models
{
    public abstract class Entity: IEntity
    {
        public int Id { get; set; }
    }
}
