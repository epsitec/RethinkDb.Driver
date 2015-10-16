




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
    public class TimesPortions : GeneratedTest {

        public TimesPortions (){
        }




        [Test]
        public void YamlTest(){

             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: rt1 = 1375147296.681
             
var rt1 = (double) (1375147296.681);             
             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: rt2 = 1375147296.682
             
var rt2 = (double) (1375147296.682);             
             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: rt3 = 1375147297.681
             
var rt3 = (double) (1375147297.681);             
             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: rt4 = 2375147296.681
             
var rt4 = (double) (2375147296.681);             
             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: rts = [rt1, rt2, rt3, rt4]
             
var rts = (IList) (r.array(rt1, rt2, rt3, rt4));             
             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: t1 = r.epoch_time(rt1)
             
var t1 = (EpochTime) (r.epochTime(rt1));             
             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: t2 = r.epoch_time(rt2)
             
var t2 = (EpochTime) (r.epochTime(rt2));             
             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: t3 = r.epoch_time(rt3)
             
var t3 = (EpochTime) (r.epochTime(rt3));             
             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: t4 = r.epoch_time(rt4)
             
var t4 = (EpochTime) (r.epochTime(rt4));             
             
             //JavaDef, times/portions.yaml, #Templates.YamlTest+DefTest.
             //Original: ts = r.expr([t1, t2, t3, t4])
             
var ts = (MakeArray) (r.expr(r.array(t1, t2, t3, t4)));             
             TestCounter++;
             
             {
                 //JavaQuery, times/portions.yaml, #11
                 /* ExpectedOriginal: ([1375142400, 1375142400, 1375142400, 2375136000]) */
                 var expected_ = r.array(1375142400L, 1375142400L, 1375142400L, 2375136000L);
                 
                 /* Original: ts.map(lambda x:x.date()).map(lambda x:x.to_epoch_time()) */
                 var obtained = runOrCatch( ts.map(x => x.date()).map(x => x.toEpochTime()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/portions.yaml, #12
                 /* ExpectedOriginal: ([0, 0, 0, 0]) */
                 var expected_ = r.array(0L, 0L, 0L, 0L);
                 
                 /* Original: ts.map(lambda x:x.date().time_of_day()) */
                 var obtained = runOrCatch( ts.map(x => x.date().timeOfDay()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/portions.yaml, #13
                 /* ExpectedOriginal: ([4896.681, 4896.682, 4897.681, 11296.681]) */
                 var expected_ = r.array(4896.681, 4896.682, 4897.681, 11296.681);
                 
                 /* Original: ts.map(lambda x:x.time_of_day()) */
                 var obtained = runOrCatch( ts.map(x => x.timeOfDay()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/portions.yaml, #14
                 /* ExpectedOriginal: ([[2013, 7, 30, 1, 21, 36.681], [2013, 7, 30, 1, 21, 36.682], [2013, 7, 30, 1, 21, 37.681], [2045, 4, 7, 3, 8, 16.681]]) */
                 var expected_ = r.array(r.array(2013L, 7L, 30L, 1L, 21L, 36.681), r.array(2013L, 7L, 30L, 1L, 21L, 36.682), r.array(2013L, 7L, 30L, 1L, 21L, 37.681), r.array(2045L, 4L, 7L, 3L, 8L, 16.681));
                 
                 /* Original: ts.map(lambda x:[x.year(), x.month(), x.day(), x.hours(), x.minutes(), x.seconds()]) */
                 var obtained = runOrCatch( ts.map(x => r.array(x.year(), x.month(), x.day(), x.hours(), x.minutes(), x.seconds())) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/portions.yaml, #15
                 /* ExpectedOriginal: rts */
                 var expected_ = rts;
                 
                 /* Original: ts.map(lambda x:r.time(x.year(), x.month(), x.day(), x.hours(), x.minutes(), x.seconds(), x.timezone())).map(lambda x:x.to_epoch_time()) */
                 var obtained = runOrCatch( ts.map(x => r.time(x.year(), x.month(), x.day(), x.hours(), x.minutes(), x.seconds(), x.timezone())).map(x => x.toEpochTime()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, times/portions.yaml, #16
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: ts.map(lambda x:r.time(x.year(), x.month(), x.day(), x.hours(), x.minutes(), x.seconds(), x.timezone())).union(ts).map(lambda x:x.to_iso8601()).distinct().count().sub(ts.count()) */
                 var obtained = runOrCatch( ts.map(x => r.time(x.year(), x.month(), x.day(), x.hours(), x.minutes(), x.seconds(), x.timezone())).union(ts).map(x => x.toIso8601()).distinct().count().sub(ts.count()) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
