using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.BLL.DummyFilesBLL
{
    public class DummyClassCollection
    {
        // Dummy-klasser
        public class Category { }
        public class SubCategory { }
        public class Question
        {
            public object AnswerOption { get; internal set; }
        }
        public class AnswerOption { }
        public class UserResult { }

    }
}
