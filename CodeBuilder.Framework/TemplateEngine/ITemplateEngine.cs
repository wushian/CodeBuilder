﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeBuilder.TemplateEngine
{
    public interface ITemplateEngine
    {
        void Run(TemplateData templateData);
    }
}