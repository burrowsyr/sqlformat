using System;
using System.Collections.Generic;

using Laan.Sql.Parser.Expressions;

namespace Laan.Sql.Parser.Entities
{
    public enum SetType
    {
        None,
        Union,
        UnionAll,
        Intersect,
        Except
    }

    public class SetOperation
    {
        public SelectStatement Statement { get; set; }
        public SetType Type { get; set; }
    }

    public class SelectStatement : ProjectionStatement
    {
        public SelectStatement() : base()
        {
            Distinct = false;
            Top = null;
            OrderBy = new List<Field>();
            GroupBy = new List<Field>();
        }

        public bool Distinct { get; set; }
        public Top Top { get; set; }
        public string Into { get; set; }
        public List<Field> OrderBy { get; set; }
        public List<Field> GroupBy { get; set; }
        public Expression Having { get; set; }
        public SetOperation SetOperation { get; set; }
    }
}
