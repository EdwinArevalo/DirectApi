﻿using System;
using System.Collections.Generic;

namespace Common.HttpHelpers
{
    public class EResponseBase<TEntity> : ICloneable where TEntity : class, new()
    {
        public int? Code { get; set; }
        public string Message { get; set; }
        public string MessageEN { get; set; }
        public bool IsResultList { get; set; } = false;
        public IEnumerable<TEntity> Listado { get; set; }
        public TEntity Objeto { get; set; }
        public string Dato { get; set; }
        //public Exception TechnicalErrors { get; set; }
        public List<string> FunctionalErrors { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("Response[Code: {0}, Message: {1},  listado: {2} , objeto {3}]", Code, Message, Listado, Objeto);
        }

    }
}
