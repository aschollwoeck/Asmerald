using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.Functions.SQLite;
using Germanium.Statements;

namespace Germanium.SQLite
{
    public static partial class TypeProofSqlSoundexExtensions
    {
        public static SoundexFunction Soundex(this SQLiteDSLContext stmt, ISelectExpression x)
        {
            return new SoundexFunction(x);
        }
        public static SoundexFunction Soundex(this Int16 x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this Int32 x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this Int64 x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this UInt16 x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this UInt32 x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this UInt64 x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this Decimal x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this Double x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this String x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this Char x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this Boolean x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this Byte x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this DateTime x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this Single x)
        {
            return new SoundexFunction(x.Expr());
        }
        public static SoundexFunction Soundex(this ISelectColumn x)
        {
            return new SoundexFunction(x);
        }
    }
}
