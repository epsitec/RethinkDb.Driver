




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;

namespace RethinkDb.Driver.Ast {
    public class Merge : ReqlQuery {
    
        public Merge (object arg) : this(new Arguments(arg), null) {
        }
        public Merge (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Merge (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.MERGE, args, optargs) {
        }

        protected Merge (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
        {
        }

    /* Static Factories */
        public static Merge FromArgs(params object[] args){
               return new Merge (new Arguments(args), null);
        }

    /* Special Methods */

    }
}