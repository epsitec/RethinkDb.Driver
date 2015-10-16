




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
    public class Regression4030 : GeneratedTest {

        public Regression4030 (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             
             //JavaDef, regression/4030.yaml, #Templates.YamlTest+DefTest.
             //Original: data = [{'id':1}, {'id':2}, {'id':3}, {'id':4}, {'id':5}, {'id':6}]
             
var data = (IList) (r.array(r.hashMap("id", 1L), r.hashMap("id", 2L), r.hashMap("id", 3L), r.hashMap("id", 4L), r.hashMap("id", 5L), r.hashMap("id", 6L)));             
             
             //JavaDef, regression/4030.yaml, #Templates.YamlTest+DefTest.
             //Original: changes = [{'id':7}, {'id':8}, {'id':9}, {'id':10}]
             
var changes = (IList) (r.array(r.hashMap("id", 7L), r.hashMap("id", 8L), r.hashMap("id", 9L), r.hashMap("id", 10L)));             
             TestCounter++;
             
             {
                 //JavaQuery, regression/4030.yaml, #3
                 /* ExpectedOriginal: partial({'errors':0, 'inserted':6}) */
                 var expected_ = partial(r.hashMap("errors", 0L).with("inserted", 6L));
                 
                 /* Original: tbl.insert(data) */
                 var obtained = runOrCatch( tbl.insert(data) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/4030.yaml, #4
                 /* ExpectedOriginal: (6) */
                 var expected_ = 6L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/4030.yaml, #5
                 /* ExpectedOriginal: bag(data * 2) */
                 var expected_ = bag((IList)Enumerable.Concat(data.OfType<object>().ToList(), data.OfType<object>().ToList()).ToList());
                 
                 /* Original: tbl.union(tbl) */
                 var obtained = runOrCatch( tbl.union(tbl) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, regression/4030.yaml, #6
                 /* ExpectedOriginal: bag(data * 2) */
                 var expected_ = bag((IList)Enumerable.Concat(data.OfType<object>().ToList(), data.OfType<object>().ToList()).ToList());
                 
                 /* Original: r.union(tbl, tbl) */
                 var obtained = runOrCatch( r.union(tbl, tbl) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
