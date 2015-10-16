




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
    public class ChangefeedsIncludeStates : GeneratedTest {

        public ChangefeedsIncludeStates (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #1
                 /* ExpectedOriginal: [{'state': 'ready'}] */
                 var expected_ = r.array(r.hashMap("state", "ready"));
                 
                 /* Original: tbl.changes(squash=true, include_states=true).limit(1) */
                 var obtained = runOrCatch( tbl.changes().optArg("squash", true).optArg("include_states", true).limit(1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #2
                 /* ExpectedOriginal: [{'state': 'initializing'}, {'new_val': None}, {'state': 'ready'}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", null), r.hashMap("state", "ready"));
                 
                 /* Original: tbl.get(0).changes(squash=true, include_states=true).limit(3) */
                 var obtained = runOrCatch( tbl.get(0L).changes().optArg("squash", true).optArg("include_states", true).limit(3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #3
                 /* ExpectedOriginal: [{'state': 'initializing'}, {'state': 'ready'}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("state", "ready"));
                 
                 /* Original: tbl.order_by(index='id').limit(10).changes(squash=true, include_states=true).limit(2) */
                 var obtained = runOrCatch( tbl.orderBy().optArg("index", "id").limit(10L).changes().optArg("squash", true).optArg("include_states", true).limit(2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #4
                 /* ExpectedOriginal: None */
                 var expected_ = null as object;
                 
                 /* Original: tbl.insert({'id':1}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 1L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #5
                 /* ExpectedOriginal: [{'state': 'initializing'}, {'new_val': {'id': 1}}, {'state': 'ready'}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", r.hashMap("id", 1L)), r.hashMap("state", "ready"));
                 
                 /* Original: tbl.order_by(index='id').limit(10).changes(squash=true, include_states=true).limit(3) */
                 var obtained = runOrCatch( tbl.orderBy().optArg("index", "id").limit(10L).changes().optArg("squash", true).optArg("include_states", true).limit(3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, changefeeds/include_states.yaml, #Templates.YamlTest+DefTest.
             //Original: tblchanges = tbl.changes(squash=true, include_states=true)
             
var tblchanges = (Changes) (tbl.changes().optArg("squash", true).optArg("include_states", true));             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #7
                 /* ExpectedOriginal: None */
                 var expected_ = null as object;
                 
                 /* Original: tbl.insert({'id':2}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #8
                 /* ExpectedOriginal: [{'state': 'ready'}, {'new_val': {'id': 2}, 'old_val': None}] */
                 var expected_ = r.array(r.hashMap("state", "ready"), r.hashMap("new_val", r.hashMap("id", 2L)).with("old_val", null));
                 
                 /* Original: fetch(tblchanges, 2) */
                 var obtained = runOrCatch( fetch(tblchanges, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, changefeeds/include_states.yaml, #Templates.YamlTest+DefTest.
             //Original: getchanges = tbl.get(2).changes(include_states=true)
             
var getchanges = (Changes) (tbl.get(2L).changes().optArg("include_states", true));             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #10
                 /* ExpectedOriginal: None */
                 var expected_ = null as object;
                 
                 /* Original: tbl.get(2).update({'a':1}) */
                 var obtained = runOrCatch( tbl.get(2L).update(r.hashMap("a", 1L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #11
                 /* ExpectedOriginal: [{'state': 'initializing'}, {'new_val': {'id': 2}}, {'state': 'ready'}, {'new_val': {'a': 1, 'id': 2}, 'old_val': {'id': 2}}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", r.hashMap("id", 2L)), r.hashMap("state", "ready"), r.hashMap("new_val", r.hashMap("a", 1L).with("id", 2L)).with("old_val", r.hashMap("id", 2L)));
                 
                 /* Original: fetch(getchanges, 4) */
                 var obtained = runOrCatch( fetch(getchanges, 4L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, changefeeds/include_states.yaml, #Templates.YamlTest+DefTest.
             //Original: limitchanges = tbl.order_by(index='id').limit(10).changes(include_states=true)
             
var limitchanges = (Changes) (tbl.orderBy().optArg("index", "id").limit(10L).changes().optArg("include_states", true));             
             
             //JavaDef, changefeeds/include_states.yaml, #Templates.YamlTest+DefTest.
             //Original: limitchangesdesc = tbl.order_by(index=r.desc('id')).limit(10).changes(include_states=true)
             
var limitchangesdesc = (Changes) (tbl.orderBy().optArg("index", r.desc("id")).limit(10L).changes().optArg("include_states", true));             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #14
                 /* ExpectedOriginal: None */
                 var expected_ = null as object;
                 
                 /* Original: tbl.insert({'id':3}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 3L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #15
                 /* ExpectedOriginal: [{'state': 'initializing'}, {'new_val': {'id': 1}}, {'new_val': {'a': 1, 'id': 2}}, {'state': 'ready'}, {'new_val': {'id': 3}, 'old_val': None}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", r.hashMap("id", 1L)), r.hashMap("new_val", r.hashMap("a", 1L).with("id", 2L)), r.hashMap("state", "ready"), r.hashMap("new_val", r.hashMap("id", 3L)).with("old_val", null));
                 
                 /* Original: fetch(limitchanges, 5) */
                 var obtained = runOrCatch( fetch(limitchanges, 5L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #16
                 /* ExpectedOriginal: [{'state': 'initializing'}, {'new_val': {'a': 1, 'id': 2}}, {'new_val': {'id': 1}}, {'state': 'ready'}, {'new_val': {'id': 3}, 'old_val': None}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", r.hashMap("a", 1L).with("id", 2L)), r.hashMap("new_val", r.hashMap("id", 1L)), r.hashMap("state", "ready"), r.hashMap("new_val", r.hashMap("id", 3L)).with("old_val", null));
                 
                 /* Original: fetch(limitchangesdesc, 5) */
                 var obtained = runOrCatch( fetch(limitchangesdesc, 5L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
