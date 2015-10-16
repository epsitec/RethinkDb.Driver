




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
    public class Regression522 : GeneratedTest {

        public Regression522 (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, regression/522.yaml, #1
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
                 //JavaQuery, regression/522.yaml, #2
                 /* ExpectedOriginal: [{'id': 1}, {'id': 2}] */
                 var expected_ = r.array(r.hashMap("id", 1L), r.hashMap("id", 2L));
                 
                 /* Original: tbl.order_by('id').skip(1) */
                 var obtained = runOrCatch( tbl.orderBy("id").skip(1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
