




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class DatumNull : GeneratedTest {

        public DatumNull (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, datum/null.yaml, #1
                 /* ExpectedOriginal: (null) */
                 var expected_ = null as object;
                 
                 /* Original: r.expr(null) */
                 var obtained = runOrCatch( r.expr((ReqlExpr) null) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/null.yaml, #2
                 /* ExpectedOriginal: NULL */
                 var expected_ = "NULL";
                 
                 /* Original: r.expr(null).type_of() */
                 var obtained = runOrCatch( r.expr((ReqlExpr) null).typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/null.yaml, #3
                 /* ExpectedOriginal: null */
                 var expected_ = "null";
                 
                 /* Original: r.expr(null).coerce_to('string') */
                 var obtained = runOrCatch( r.expr((ReqlExpr) null).coerceTo("string") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/null.yaml, #4
                 /* ExpectedOriginal: (null) */
                 var expected_ = null as object;
                 
                 /* Original: r.expr(null).coerce_to('null') */
                 var obtained = runOrCatch( r.expr((ReqlExpr) null).coerceTo("null") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
