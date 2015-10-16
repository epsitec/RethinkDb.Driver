




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
    public class TimesIndex : GeneratedTest {

        public TimesIndex (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: ts={"timezone":"-07:00","epoch_time":1375445162.0872,"$reql_type$":"TIME"}
             
var ts = (MapObject) (r.hashMap("timezone", "-07:00").with("epoch_time", 1375445162.0872).with("$reql_type$", "TIME"));             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: t1={"timezone":"-07:00","epoch_time":1375445163.0872,"$reql_type$":"TIME"}
             
var t1 = (MapObject) (r.hashMap("timezone", "-07:00").with("epoch_time", 1375445163.0872).with("$reql_type$", "TIME"));             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: t2={"timezone":"-07:00","epoch_time":1375445163.08832,"$reql_type$":"TIME"}
             
var t2 = (MapObject) (r.hashMap("timezone", "-07:00").with("epoch_time", 1375445163.08832).with("$reql_type$", "TIME"));             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: t3={"timezone":"-07:00","epoch_time":1375445163.08943,"$reql_type$":"TIME"}
             
var t3 = (MapObject) (r.hashMap("timezone", "-07:00").with("epoch_time", 1375445163.08943).with("$reql_type$", "TIME"));             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: t4={"timezone":"-07:00","epoch_time":1375445163.09055,"$reql_type$":"TIME"}
             
var t4 = (MapObject) (r.hashMap("timezone", "-07:00").with("epoch_time", 1375445163.09055).with("$reql_type$", "TIME"));             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: t5={"timezone":"-07:00","epoch_time":1375445163.09166,"$reql_type$":"TIME"}
             
var t5 = (MapObject) (r.hashMap("timezone", "-07:00").with("epoch_time", 1375445163.09166).with("$reql_type$", "TIME"));             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: te={"timezone":"-07:00","epoch_time":1375445164.0872,"$reql_type$":"TIME"}
             
var te = (MapObject) (r.hashMap("timezone", "-07:00").with("epoch_time", 1375445164.0872).with("$reql_type$", "TIME"));             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: trows = [{'id':t1}, {'id':t2}, {'id':t3}, {'id':t4}, {'id':t5}]
             
var trows = (IList) (r.array(r.hashMap("id", t1), r.hashMap("id", t2), r.hashMap("id", t3), r.hashMap("id", t4), r.hashMap("id", t5)));             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #9
                 /* ExpectedOriginal: 5 */
                 var expected_ = 5L;
                 
                 /* Original: tbl.insert(trows)['inserted'] */
                 var obtained = runOrCatch( tbl.insert(trows).g("inserted") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: bad_insert = [{'id':r.expr(t1).in_timezone("Z")}]
             
var bad_insert = (IList) (r.array(r.hashMap("id", r.expr(t1).inTimezone("Z"))));             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #11
                 /* ExpectedOriginal: ("Duplicate primary key `id`:\n{\n\t\"id\":\t{\n\t\t\"$reql_type$\":\t\"TIME\",\n\t\t\"epoch_time\":\t1375445163.087,\n\t\t\"timezone\":\t\"-07:00\"\n\t}\n}\n{\n\t\"id\":\t{\n\t\t\"$reql_type$\":\t\"TIME\",\n\t\t\"epoch_time\":\t1375445163.087,\n\t\t\"timezone\":\t\"+00:00\"\n\t}\n}") */
                 var expected_ = "Duplicate primary key `id`:\n{\n\t\"id\":\t{\n\t\t\"$reql_type$\":\t\"TIME\",\n\t\t\"epoch_time\":\t1375445163.087,\n\t\t\"timezone\":\t\"-07:00\"\n\t}\n}\n{\n\t\"id\":\t{\n\t\t\"$reql_type$\":\t\"TIME\",\n\t\t\"epoch_time\":\t1375445163.087,\n\t\t\"timezone\":\t\"+00:00\"\n\t}\n}";
                 
                 /* Original: tbl.insert(bad_insert)['first_error'] */
                 var obtained = runOrCatch( tbl.insert(bad_insert).g("first_error") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #12
                 /* ExpectedOriginal: 5 */
                 var expected_ = 5L;
                 
                 /* Original: tbl.between(ts, te).count() */
                 var obtained = runOrCatch( tbl.between(ts, te).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #13
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(t1, t4).count() */
                 var obtained = runOrCatch( tbl.between(t1, t4).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #14
                 /* ExpectedOriginal: 4 */
                 var expected_ = 4L;
                 
                 /* Original: tbl.between(t1, t4, right_bound='closed').count() */
                 var obtained = runOrCatch( tbl.between(t1, t4).optArg("right_bound", "closed").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #15
                 /* ExpectedOriginal: 5 */
                 var expected_ = 5L;
                 
                 /* Original: tbl.between(r.expr(ts).in_timezone("+06:00"), te).count() */
                 var obtained = runOrCatch( tbl.between(r.expr(ts).inTimezone("+06:00"), te).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #16
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(t1, r.expr(t4).in_timezone("+08:00")).count() */
                 var obtained = runOrCatch( tbl.between(t1, r.expr(t4).inTimezone("+08:00")).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #17
                 /* ExpectedOriginal: 4 */
                 var expected_ = 4L;
                 
                 /* Original: tbl.between(r.expr(t1).in_timezone("Z"), t4, right_bound='closed').count() */
                 var obtained = runOrCatch( tbl.between(r.expr(t1).inTimezone("Z"), t4).optArg("right_bound", "closed").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #18
                 /* ExpectedOriginal: 5 */
                 var expected_ = 5L;
                 
                 /* Original: tbl.update(lambda row:{'a':row['id']})['replaced'] */
                 var obtained = runOrCatch( tbl.update(row => r.hashMap("a", row.g("id"))).g("replaced") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #19
                 /* ExpectedOriginal: ({'created':1}) */
                 var expected_ = r.hashMap("created", 1L);
                 
                 /* Original: tbl.index_create('a') */
                 var obtained = runOrCatch( tbl.indexCreate("a") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #20
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.index_wait('a').count() */
                 var obtained = runOrCatch( tbl.indexWait("a").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #21
                 /* ExpectedOriginal: 5 */
                 var expected_ = 5L;
                 
                 /* Original: tbl.between(ts, te, index='a').count() */
                 var obtained = runOrCatch( tbl.between(ts, te).optArg("index", "a").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #22
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(t1, t4, index='a').count() */
                 var obtained = runOrCatch( tbl.between(t1, t4).optArg("index", "a").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #23
                 /* ExpectedOriginal: 4 */
                 var expected_ = 4L;
                 
                 /* Original: tbl.between(t1, t4, right_bound='closed', index='a').count() */
                 var obtained = runOrCatch( tbl.between(t1, t4).optArg("right_bound", "closed").optArg("index", "a").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #24
                 /* ExpectedOriginal: 5 */
                 var expected_ = 5L;
                 
                 /* Original: tbl.between(r.expr(ts).in_timezone("+06:00"), te, index='a').count() */
                 var obtained = runOrCatch( tbl.between(r.expr(ts).inTimezone("+06:00"), te).optArg("index", "a").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #25
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(t1, r.expr(t4).in_timezone("+08:00"), index='a').count() */
                 var obtained = runOrCatch( tbl.between(t1, r.expr(t4).inTimezone("+08:00")).optArg("index", "a").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #26
                 /* ExpectedOriginal: 4 */
                 var expected_ = 4L;
                 
                 /* Original: tbl.between(r.expr(t1).in_timezone("Z"), t4, right_bound='closed', index='a').count() */
                 var obtained = runOrCatch( tbl.between(r.expr(t1).inTimezone("Z"), t4).optArg("right_bound", "closed").optArg("index", "a").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #27
                 /* ExpectedOriginal: ({'created':1}) */
                 var expected_ = r.hashMap("created", 1L);
                 
                 /* Original: tbl.index_create('b', lambda row:r.branch(row['id'] < t4, row['a'], null)) */
                 var obtained = runOrCatch( tbl.indexCreate("b", row => r.branch(row.g("id").lt(t4), row.g("a"), (ReqlExpr) null)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #28
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.index_wait('b').count() */
                 var obtained = runOrCatch( tbl.indexWait("b").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #29
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.index_wait('b').count() */
                 var obtained = runOrCatch( tbl.indexWait("b").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #30
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(ts, te, index='b').count() */
                 var obtained = runOrCatch( tbl.between(ts, te).optArg("index", "b").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #31
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(t1, t4, index='b').count() */
                 var obtained = runOrCatch( tbl.between(t1, t4).optArg("index", "b").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #32
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(t1, t4, right_bound='closed', index='b').count() */
                 var obtained = runOrCatch( tbl.between(t1, t4).optArg("right_bound", "closed").optArg("index", "b").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #33
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(r.expr(ts).in_timezone("+06:00"), te, index='b').count() */
                 var obtained = runOrCatch( tbl.between(r.expr(ts).inTimezone("+06:00"), te).optArg("index", "b").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #34
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(t1, r.expr(t4).in_timezone("+08:00"), index='b').count() */
                 var obtained = runOrCatch( tbl.between(t1, r.expr(t4).inTimezone("+08:00")).optArg("index", "b").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #35
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.between(r.expr(t1).in_timezone("Z"), t4, right_bound='closed', index='b').count() */
                 var obtained = runOrCatch( tbl.between(r.expr(t1).inTimezone("Z"), t4).optArg("right_bound", "closed").optArg("index", "b").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: oldtime = datetime.fromtimestamp(1375147296.681, PacificTimeZone())
             
var oldtime = (DateTimeOffset) (datetime.fromtimestamp(1375147296.681, PacificTimeZone()));             
             
             //JavaDef, times/index.yaml, #Templates.YamlTest+DefTest.
             //Original: curtime = datetime.now()
             
var curtime = (DateTimeOffset) (datetime.now());             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #38
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.insert([{'id':oldtime}])['inserted'] */
                 var obtained = runOrCatch( tbl.insert(r.array(r.hashMap("id", oldtime))).g("inserted") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/index.yaml, #39
                 /* ExpectedOriginal: ("PTYPE<TIME>") */
                 var expected_ = "PTYPE<TIME>";
                 
                 /* Original: tbl.get(oldtime)['id'].type_of() */
                 var obtained = runOrCatch( tbl.get(oldtime).g("id").typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
