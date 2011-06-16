﻿namespace Nancy.ViewEngines.Razor
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Web;

    public abstract class NancyRazorViewBase
    {
        public string Layout { get; set; }

        public TextWriter Writer { get; set; }

        public string Code { get; set; }

        public string Path { get; set; }

        public dynamic Model { get; set; }

        public HtmlHelpers Html { get; set; }

        public IDictionary<string, Action> Sections { get; set; }

        public abstract void Execute();

        protected NancyRazorViewBase()
        {
            this.Sections = new Dictionary<string, Action>();
        }

        // Writes the results of expressions like: "@foo.Bar"
        public virtual void Write(object value)
        {
            WriteLiteral(HttpUtility.HtmlEncode(value));
        }

        // Writes literals like markup: "<p>Foo</p>"
        public virtual void WriteLiteral(object value)
        {
            Writer.Write(value);
        }

        // Stores sections
        public virtual void DefineSection(string sectionName, Action action)
        {
            // This crashes with a duplicate key exception, even though it's only called once :-)
            //this.Sections.Add(sectionName, action);
        }
    }
}