




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
    public class TimesTimezones : GeneratedTest {

        public TimesTimezones (){
        }




        [Test]
        public void YamlTest(){

             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: t1 = r.time(2013, r.july, 29, 23, 30, 0, "+00:00")
             
var t1 = (Time) (r.time(2013L, r.july(), 29L, 23L, 30L, 0L, "+00:00"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tutc1 = t1.in_timezone("Z")
             
var tutc1 = (InTimezone) (t1.inTimezone("Z"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tutc2 = t1.in_timezone("+00:00")
             
var tutc2 = (InTimezone) (t1.inTimezone("+00:00"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tutc3 = t1.in_timezone("+00")
             
var tutc3 = (InTimezone) (t1.inTimezone("+00"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tutcs = r.expr([tutc1, tutc2, tutc3])
             
var tutcs = (MakeArray) (r.expr(r.array(tutc1, tutc2, tutc3)));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tm1 = t1.in_timezone("-00:59")
             
var tm1 = (InTimezone) (t1.inTimezone("-00:59"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tm2 = t1.in_timezone("-01:00")
             
var tm2 = (InTimezone) (t1.inTimezone("-01:00"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tm3 = t1.in_timezone("-01:01")
             
var tm3 = (InTimezone) (t1.inTimezone("-01:01"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tms = r.expr([tm1, tm2, tm3])
             
var tms = (MakeArray) (r.expr(r.array(tm1, tm2, tm3)));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tp1 = t1.in_timezone("+00:59")
             
var tp1 = (InTimezone) (t1.inTimezone("+00:59"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tp2 = t1.in_timezone("+01:00")
             
var tp2 = (InTimezone) (t1.inTimezone("+01:00"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tp3 = t1.in_timezone("+01:01")
             
var tp3 = (InTimezone) (t1.inTimezone("+01:01"));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: tps = r.expr([tp1, tp2, tp3])
             
var tps = (MakeArray) (r.expr(r.array(tp1, tp2, tp3)));             
             
             //JavaDef, times/timezones.yaml, #Templates.YamlTest+DefTest.
             //Original: ts = tutcs.union(tms).union(tps).union([t1])
             
var ts = (Union) (tutcs.union(tms).union(tps).union(r.array(t1)));             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #15
                 /* ExpectedOriginal: ([["+00:00", 29], ["+00:00", 29], ["+00:00", 29]]) */
                 var expected_ = r.array(r.array("+00:00", 29L), r.array("+00:00", 29L), r.array("+00:00", 29L));
                 
                 /* Original: tutcs.map(lambda x:[x.timezone(), x.day()]) */
                 var obtained = runOrCatch( tutcs.map(x => r.array(x.timezone(), x.day())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #16
                 /* ExpectedOriginal: ([["-00:59", 29], ["-01:00", 29], ["-01:01", 29]]) */
                 var expected_ = r.array(r.array("-00:59", 29L), r.array("-01:00", 29L), r.array("-01:01", 29L));
                 
                 /* Original: tms.map(lambda x:[x.timezone(), x.day()]) */
                 var obtained = runOrCatch( tms.map(x => r.array(x.timezone(), x.day())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #17
                 /* ExpectedOriginal: ([["+00:59", 30], ["+01:00", 30], ["+01:01", 30]]) */
                 var expected_ = r.array(r.array("+00:59", 30L), r.array("+01:00", 30L), r.array("+01:01", 30L));
                 
                 /* Original: tps.map(lambda x:[x.timezone(), x.day()]) */
                 var obtained = runOrCatch( tps.map(x => r.array(x.timezone(), x.day())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #18
                 /* ExpectedOriginal: ([0]) */
                 var expected_ = r.array(0L);
                 
                 /* Original: ts.concat_map(lambda x:ts.map(lambda y:x - y)).distinct() */
                 var obtained = runOrCatch( ts.concatMap(x => ts.map(y => r.sub(x, y))).distinct() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #19
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Timezone `` does not start with `-` or `+`.') */
                 var expected_ = err("ReqlQueryLogicError", "Timezone `` does not start with `-` or `+`.");
                 
                 /* Original: r.now().in_timezone("") */
                 var obtained = runOrCatch( r.now().inTimezone("") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #20
                 /* ExpectedOriginal: err('ReqlQueryLogicError', '`-00` is not a valid time offset.') */
                 var expected_ = err("ReqlQueryLogicError", "`-00` is not a valid time offset.");
                 
                 /* Original: r.now().in_timezone("-00") */
                 var obtained = runOrCatch( r.now().inTimezone("-00") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #21
                 /* ExpectedOriginal: err('ReqlQueryLogicError', '`-00:00` is not a valid time offset.') */
                 var expected_ = err("ReqlQueryLogicError", "`-00:00` is not a valid time offset.");
                 
                 /* Original: r.now().in_timezone("-00:00") */
                 var obtained = runOrCatch( r.now().inTimezone("-00:00") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #22
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Timezone `UTC+00` does not start with `-` or `+`.') */
                 var expected_ = err("ReqlQueryLogicError", "Timezone `UTC+00` does not start with `-` or `+`.");
                 
                 /* Original: r.now().in_timezone("UTC+00") */
                 var obtained = runOrCatch( r.now().inTimezone("UTC+00") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #23
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Minutes out of range in `+00:60`.') */
                 var expected_ = err("ReqlQueryLogicError", "Minutes out of range in `+00:60`.");
                 
                 /* Original: r.now().in_timezone("+00:60") */
                 var obtained = runOrCatch( r.now().inTimezone("+00:60") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #24
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Hours out of range in `+25:00`.') */
                 var expected_ = err("ReqlQueryLogicError", "Hours out of range in `+25:00`.");
                 
                 /* Original: r.now().in_timezone("+25:00") */
                 var obtained = runOrCatch( r.now().inTimezone("+25:00") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #25
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Timezone `` does not start with `-` or `+`.') */
                 var expected_ = err("ReqlQueryLogicError", "Timezone `` does not start with `-` or `+`.");
                 
                 /* Original: r.time(2013, 1, 1, "") */
                 var obtained = runOrCatch( r.time(2013L, 1L, 1L, "") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #26
                 /* ExpectedOriginal: err('ReqlQueryLogicError', '`-00` is not a valid time offset.') */
                 var expected_ = err("ReqlQueryLogicError", "`-00` is not a valid time offset.");
                 
                 /* Original: r.time(2013, 1, 1, "-00") */
                 var obtained = runOrCatch( r.time(2013L, 1L, 1L, "-00") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #27
                 /* ExpectedOriginal: err('ReqlQueryLogicError', '`-00:00` is not a valid time offset.') */
                 var expected_ = err("ReqlQueryLogicError", "`-00:00` is not a valid time offset.");
                 
                 /* Original: r.time(2013, 1, 1, "-00:00") */
                 var obtained = runOrCatch( r.time(2013L, 1L, 1L, "-00:00") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #28
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Timezone `UTC+00` does not start with `-` or `+`.') */
                 var expected_ = err("ReqlQueryLogicError", "Timezone `UTC+00` does not start with `-` or `+`.");
                 
                 /* Original: r.time(2013, 1, 1, "UTC+00") */
                 var obtained = runOrCatch( r.time(2013L, 1L, 1L, "UTC+00") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #29
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Minutes out of range in `+00:60`.') */
                 var expected_ = err("ReqlQueryLogicError", "Minutes out of range in `+00:60`.");
                 
                 /* Original: r.time(2013, 1, 1, "+00:60") */
                 var obtained = runOrCatch( r.time(2013L, 1L, 1L, "+00:60") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #30
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Hours out of range in `+25:00`.') */
                 var expected_ = err("ReqlQueryLogicError", "Hours out of range in `+25:00`.");
                 
                 /* Original: r.time(2013, 1, 1, "+25:00") */
                 var obtained = runOrCatch( r.time(2013L, 1L, 1L, "+25:00") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #31
                 /* ExpectedOriginal: ("2015-07-08T00:00:00-08:00") */
                 var expected_ = "2015-07-08T00:00:00-08:00";
                 
                 /* Original: r.epoch_time(1436428422.339).in_timezone('-08:00').date().to_iso8601() */
                 var obtained = runOrCatch( r.epochTime(1436428422.339).inTimezone("-08:00").date().toIso8601() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/timezones.yaml, #32
                 /* ExpectedOriginal: ("2015-07-09T00:00:00-07:00") */
                 var expected_ = "2015-07-09T00:00:00-07:00";
                 
                 /* Original: r.epoch_time(1436428422.339).in_timezone('-07:00').date().to_iso8601() */
                 var obtained = runOrCatch( r.epochTime(1436428422.339).inTimezone("-07:00").date().toIso8601() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
