﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ManpowerManagement.Service.Helper
{
    public class Enums
    {
        public enum Role
        {
            [Description("Admin")]
            Admin = 1,
            [Description("Business")]
            Business = 2,
            [Description("User")]
            User = 3
        }
        public static string GetDescription(System.Enum value)
        {
            var enumMember = value.GetType().GetMember(value.ToString()).FirstOrDefault();
            var descriptionAttribute =
                enumMember == null
                    ? default(DescriptionAttribute)
                    : enumMember.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
            return
                descriptionAttribute == null
                    ? value.ToString()
                    : descriptionAttribute.Description;
        }
    }
}
