




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
    public class Control : GeneratedTest {

        public Control (){
                tableVars.Add( "tbl" );
                tableVars.Add( "tbl2" );
        }


            public static Table tbl = r.db(DbName).table("tbl");
            public static Table tbl2 = r.db(DbName).table("tbl2");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #1
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(1).do(lambda v: v * 2) */
                 var obtained = runOrCatch( r.expr(1L).do_(v => r.mul(v, 2L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #2
                 /* ExpectedOriginal: [0, 1, 2, 3] */
                 var expected_ = r.array(0L, 1L, 2L, 3L);
                 
                 /* Original: r.expr([0, 1, 2]).do(lambda v: v.append(3)) */
                 var obtained = runOrCatch( r.expr(r.array(0L, 1L, 2L)).do_(v => v.append(3L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #3
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: r.do(1, 2, lambda x, y: x + y) */
                 var obtained = runOrCatch( r.do_(1L, 2L, (x, y) => r.add(x, y)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #4
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.do(lambda: 1) */
                 var obtained = runOrCatch( r.do_(() => 1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #7
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.do(1) */
                 var obtained = runOrCatch( r.do_(1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #11
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type ARRAY but found STRING.", [1, 0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type ARRAY but found STRING.", r.array(1L, 0L));
                 
                 /* Original: r.expr('abc').do(lambda v: v.append(3)) */
                 var obtained = runOrCatch( r.expr("abc").do_(v => v.append(3L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #12
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", [1, 1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", r.array(1L, 1L));
                 
                 /* Original: r.expr('abc').do(lambda v: v + 3) */
                 var obtained = runOrCatch( r.expr("abc").do_(v => r.add(v, 3L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #13
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", r.array(1L));
                 
                 /* Original: r.expr('abc').do(lambda v: v + 'def') + 3 */
                 var obtained = runOrCatch( r.expr("abc").do_(v => r.add(v, "def")).add(3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #17
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.branch(True, 1, 2) */
                 var obtained = runOrCatch( r.branch(true, 1L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #18
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.branch(False, 1, 2) */
                 var obtained = runOrCatch( r.branch(false, 1L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #19
                 /* ExpectedOriginal: ("c") */
                 var expected_ = "c";
                 
                 /* Original: r.branch(1, 'c', False) */
                 var obtained = runOrCatch( r.branch(1L, "c", false) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #20
                 /* ExpectedOriginal: ([]) */
                 var expected_ = r.array();
                 
                 /* Original: r.branch(null, {}, []) */
                 var obtained = runOrCatch( r.branch((ReqlExpr) null, r.hashMap(), r.array()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #21
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type DATUM but found DATABASE:", []) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type DATUM but found DATABASE:", r.array());
                 
                 /* Original: r.branch(r.db('test'), 1, 2) */
                 var obtained = runOrCatch( r.branch(r.db("test"), 1L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #22
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type DATUM but found TABLE:", []) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type DATUM but found TABLE:", r.array());
                 
                 /* Original: r.branch(tbl, 1, 2) */
                 var obtained = runOrCatch( r.branch(tbl, 1L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #23
                 /* ExpectedOriginal: err("ReqlUserError", "a", []) */
                 var expected_ = err("ReqlUserError", "a", r.array());
                 
                 /* Original: r.branch(r.error("a"), 1, 2) */
                 var obtained = runOrCatch( r.branch(r.error(), 1L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #24
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.branch([], 1, 2) */
                 var obtained = runOrCatch( r.branch(r.array(), 1L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #25
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.branch({}, 1, 2) */
                 var obtained = runOrCatch( r.branch(r.hashMap(), 1L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #26
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.branch("a", 1, 2) */
                 var obtained = runOrCatch( r.branch("a", 1L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #27
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.branch(1.2, 1, 2) */
                 var obtained = runOrCatch( r.branch(1.2, 1L, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #28
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.branch(True, 1, True, 2, 3) */
                 var obtained = runOrCatch( r.branch(true, 1L, true, 2L, 3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #29
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.branch(True, 1, False, 2, 3) */
                 var obtained = runOrCatch( r.branch(true, 1L, false, 2L, 3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #30
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.branch(False, 1, True, 2, 3) */
                 var obtained = runOrCatch( r.branch(false, 1L, true, 2L, 3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #31
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: r.branch(False, 1, False, 2, 3) */
                 var obtained = runOrCatch( r.branch(false, 1L, false, 2L, 3L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #32
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot call `branch` term with an even number of arguments.") */
                 var expected_ = err("ReqlQueryLogicError", "Cannot call `branch` term with an even number of arguments.");
                 
                 /* Original: r.branch(True, 1, True, 2) */
                 var obtained = runOrCatch( r.branch(true, 1L, true, 2L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #33
                 /* ExpectedOriginal: err("ReqlUserError", "Hello World", [0]) */
                 var expected_ = err("ReqlUserError", "Hello World", r.array(0L));
                 
                 /* Original: r.error('Hello World') */
                 var obtained = runOrCatch( r.error() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #34
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", r.array(0L));
                 
                 /* Original: r.error(5) */
                 var obtained = runOrCatch( r.error() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #37
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.js('1 + 1') */
                 var obtained = runOrCatch( r.js("1 + 1") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #38
                 /* ExpectedOriginal: 4 */
                 var expected_ = 4L;
                 
                 /* Original: r.js('1 + 1; 2 + 2') */
                 var obtained = runOrCatch( r.js("1 + 1; 2 + 2") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #39
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: r.do(1, 2, r.js('(function(a, b) { return a + b; })')) */
                 var obtained = runOrCatch( r.do_(1L, 2L, r.js("(function(a, b) { return a + b; })")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #40
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(1).do(r.js('(function(x) { return x + 1; })')) */
                 var obtained = runOrCatch( r.expr(1L).do_(r.js("(function(x) { return x + 1; })")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #41
                 /* ExpectedOriginal: foobar */
                 var expected_ = "foobar";
                 
                 /* Original: r.expr('foo').do(r.js('(function(x) { return x + "bar"; })')) */
                 var obtained = runOrCatch( r.expr("foo").do_(r.js("(function(x) { return x + \"bar\"; })")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #42
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: r.js('1 + 2', timeout=1.2) */
                 var obtained = runOrCatch( r.js("1 + 2").optArg("timeout", 1.2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #43
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Query result must be of type DATUM, GROUPED_DATA, or STREAM (got FUNCTION).", [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Query result must be of type DATUM, GROUPED_DATA, or STREAM (got FUNCTION).", r.array(0L));
                 
                 /* Original: r.js('(function() { return 1; })') */
                 var obtained = runOrCatch( r.js("(function() { return 1; })") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #44
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "SyntaxError: Unexpected token (", [0]) */
                 var expected_ = err("ReqlQueryLogicError", "SyntaxError: Unexpected token (", r.array(0L));
                 
                 /* Original: r.js('function() { return 1; }') */
                 var obtained = runOrCatch( r.js("function() { return 1; }") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #45
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.do(1, 2, r.js('(function(a) { return a; })')) */
                 var obtained = runOrCatch( r.do_(1L, 2L, r.js("(function(a) { return a; })")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #46
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.do(1, 2, r.js('(function(a, b, c) { return a; })')) */
                 var obtained = runOrCatch( r.do_(1L, 2L, r.js("(function(a, b, c) { return a; })")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #47
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot convert javascript `undefined` to ql::datum_t.", [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert javascript `undefined` to ql::datum_t.", r.array(0L));
                 
                 /* Original: r.do(1, 2, r.js('(function(a, b, c) { return c; })')) */
                 var obtained = runOrCatch( r.do_(1L, 2L, r.js("(function(a, b, c) { return c; })")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #48
                 /* ExpectedOriginal: ([2, 3]) */
                 var expected_ = r.array(2L, 3L);
                 
                 /* Original: r.expr([1, 2, 3]).filter(r.js('(function(a) { return a >= 2; })')) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).filter(r.js("(function(a) { return a >= 2; })")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #49
                 /* ExpectedOriginal: ([2, 3, 4]) */
                 var expected_ = r.array(2L, 3L, 4L);
                 
                 /* Original: r.expr([1, 2, 3]).map(r.js('(function(a) { return a + 1; })')) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).map(r.js("(function(a) { return a + 1; })")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #50
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type FUNCTION but found DATUM:", [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type FUNCTION but found DATUM:", r.array(0L));
                 
                 /* Original: r.expr([1, 2, 3]).map(r.js('1')) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).map(r.js("1")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #51
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot convert javascript `undefined` to ql::datum_t.", [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert javascript `undefined` to ql::datum_t.", r.array(0L));
                 
                 /* Original: r.expr([1, 2, 3]).filter(r.js('(function(a) {})')) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).filter(r.js("(function(a) {})")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #53
                 /* ExpectedOriginal: ([1, 2, 3]) */
                 var expected_ = r.array(1L, 2L, 3L);
                 
                 /* Original: r.expr([1, 2, 3]).filter('foo') */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).filter("foo") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #54
                 /* ExpectedOriginal: ([1, 2, 4]) */
                 var expected_ = r.array(1L, 2L, 4L);
                 
                 /* Original: r.expr([1, 2, 4]).filter([]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 4L)).filter(r.array()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #55
                 /* ExpectedOriginal: ([]) */
                 var expected_ = r.array();
                 
                 /* Original: r.expr([1, 2, 3]).filter(null) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).filter((ReqlExpr) null) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #56
                 /* ExpectedOriginal: ([]) */
                 var expected_ = r.array();
                 
                 /* Original: r.expr([1, 2, 4]).filter(False) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 4L)).filter(false) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #57
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #58
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':3}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 3L);
                 
                 /* Original: r.expr([1, 2, 3]).for_each(lambda row:tbl.insert({ 'id':row })) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).forEach(row => tbl.insert(r.hashMap("id", row))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #59
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #60
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':9,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 9L).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: r.expr([1,2,3]).for_each(lambda row:tbl.update({'foo':row})) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).forEach(row => tbl.update(r.hashMap("foo", row))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #61
                 /* ExpectedOriginal: ({'first_error':"Duplicate primary key `id`:\n{\n\t\"foo\":\t3,\n\t\"id\":\t1\n}\n{\n\t\"id\":\t1\n}",'deleted':0.0,'replaced':0.0,'unchanged':0.0,'errors':3,'skipped':0.0,'inserted':3}) */
                 var expected_ = r.hashMap("first_error", "Duplicate primary key `id`:\n{\n\t\"foo\":\t3,\n\t\"id\":\t1\n}\n{\n\t\"id\":\t1\n}").with("deleted", 0.0).with("replaced", 0.0).with("unchanged", 0.0).with("errors", 3L).with("skipped", 0.0).with("inserted", 3L);
                 
                 /* Original: r.expr([1,2,3]).for_each(lambda row:[tbl.insert({ 'id':row }), tbl.insert({ 'id':row*10 })]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).forEach(row => r.array(tbl.insert(r.hashMap("id", row)), tbl.insert(r.hashMap("id", r.mul(row, 10L))))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #62
                 /* ExpectedOriginal: 6 */
                 var expected_ = 6L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, control.yaml, #Templates.YamlTest+DefTest.
             //Original: tableCount = tbl2.count()
             
var tableCount = (Count) (tbl2.count());             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #65
                 /* ExpectedOriginal: tableCount + 1 */
                 var expected_ = r.add(tableCount, 1L);
                 
                 /* Original: tbl2.count() */
                 var obtained = runOrCatch( tbl2.count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #66
                 /* ExpectedOriginal: ({'deleted':0.0,'replaced':36,'unchanged':0.0,'errors':0.0,'skipped':0.0,'inserted':0.0}) */
                 var expected_ = r.hashMap("deleted", 0.0).with("replaced", 36L).with("unchanged", 0.0).with("errors", 0.0).with("skipped", 0.0).with("inserted", 0.0);
                 
                 /* Original: r.expr([1,2,3]).for_each(lambda row:[tbl.update({'foo':row}), tbl.update({'bar':row})]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).forEach(row => r.array(tbl.update(r.hashMap("foo", row)), tbl.update(r.hashMap("bar", row)))) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #69
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "FOR_EACH expects one or more basic write queries.  Expected type ARRAY but found NUMBER.", [1, 1]) */
                 var expected_ = err("ReqlQueryLogicError", "FOR_EACH expects one or more basic write queries.  Expected type ARRAY but found NUMBER.", r.array(1L, 1L));
                 
                 /* Original: r.expr([1, 2, 3]).for_each(lambda x:x) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).forEach(x => x) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #71
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "FOR_EACH expects one or more basic write queries.", [1, 1]) */
                 var expected_ = err("ReqlQueryLogicError", "FOR_EACH expects one or more basic write queries.", r.array(1L, 1L));
                 
                 /* Original: r.expr([1, 2, 3]).for_each(lambda row:tbl) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).forEach(row => tbl) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, control.yaml, #80
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.expr(1).do(r.db('test').table_create('nested_table')) */
                 var obtained = runOrCatch( r.expr(1L).do_(r.db("test").tableCreate("nested_table")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
