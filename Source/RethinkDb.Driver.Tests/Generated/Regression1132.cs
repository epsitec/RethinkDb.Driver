




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
    public class Regression1132 : GeneratedTest {

        public Regression1132 (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, regression/1132.yaml, #1
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Duplicate key `a` in JSON.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Duplicate key `a` in JSON.", r.array());
                 
                 /* Original: r.json('{"a":1,"a":2}') */
                 var obtained = runOrCatch( r.json("{\"a\":1,\"a\":2}") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
