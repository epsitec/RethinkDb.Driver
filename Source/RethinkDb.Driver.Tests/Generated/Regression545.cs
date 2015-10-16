




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
    public class Regression545 : GeneratedTest {

        public Regression545 (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, regression/545.yaml, #1
                 /* ExpectedOriginal: None */
                 var expected_ = null as object;
                 
                 /* Original: tbl.insert([{'id':0}, {'id':1}, {'id':2}]) */
                 var obtained = runOrCatch( tbl.insert(r.array(r.hashMap("id", 0L), r.hashMap("id", 1L), r.hashMap("id", 2L))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/545.yaml, #2
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.reduce(r.js("(function(x,y){return 1;})")) */
                 var obtained = runOrCatch( tbl.reduce(r.js("(function(x,y){return 1;})")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/545.yaml, #3
                 /* ExpectedOriginal: ({'id':3}) */
                 var expected_ = r.hashMap("id", 3L);
                 
                 /* Original: tbl.reduce(r.js("(function(x,y){return {id:x[\"id\"] + y[\"id\"]};})")) */
                 var obtained = runOrCatch( tbl.reduce(r.js("(function(x,y){return {id:x[\"id\"] + y[\"id\"]};})")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
