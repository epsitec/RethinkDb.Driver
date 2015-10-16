




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
    public class DatumTypeof : GeneratedTest {

        public DatumTypeof (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, datum/typeof.yaml, #1
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
                 //JavaQuery, datum/typeof.yaml, #2
                 /* ExpectedOriginal: NULL */
                 var expected_ = "NULL";
                 
                 /* Original: r.type_of(null) */
                 var obtained = runOrCatch( r.typeOf((ReqlExpr) null) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
