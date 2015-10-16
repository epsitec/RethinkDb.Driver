




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
    public class DatumNumber : GeneratedTest {

        public DatumNumber (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #1
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(1) */
                 var obtained = runOrCatch( r.expr(1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #2
                 /* ExpectedOriginal: -1 */
                 var expected_ = -1L;
                 
                 /* Original: r.expr(-1) */
                 var obtained = runOrCatch( r.expr(-1L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #3
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: r.expr(0) */
                 var obtained = runOrCatch( r.expr(0L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #4
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.expr(1.0) */
                 var obtained = runOrCatch( r.expr(1.0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #5
                 /* ExpectedOriginal: 1.5 */
                 var expected_ = 1.5;
                 
                 /* Original: r.expr(1.5) */
                 var obtained = runOrCatch( r.expr(1.5) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #6
                 /* ExpectedOriginal: -0.5 */
                 var expected_ = -0.5;
                 
                 /* Original: r.expr(-0.5) */
                 var obtained = runOrCatch( r.expr(-0.5) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #7
                 /* ExpectedOriginal: 67498.89278 */
                 var expected_ = 67498.89278;
                 
                 /* Original: r.expr(67498.89278) */
                 var obtained = runOrCatch( r.expr(67498.89278) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #8
                 /* ExpectedOriginal: 1234567890 */
                 var expected_ = 1234567890L;
                 
                 /* Original: r.expr(1234567890) */
                 var obtained = runOrCatch( r.expr(1234567890L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #9
                 /* ExpectedOriginal: -73850380122423 */
                 var expected_ = -73850380122423L;
                 
                 /* Original: r.expr(-73850380122423) */
                 var obtained = runOrCatch( r.expr(-73850380122423L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #10
                 /* ExpectedOriginal: float(1234567890123456789012345678901234567890) */
                 var expected_ = float_(1234567890123456789012345678901234567890.0);
                 
                 /* Original: r.expr(1234567890123456789012345678901234567890) */
                 var obtained = runOrCatch( r.expr(1234567890123456789012345678901234567890.0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #11
                 /* ExpectedOriginal: (123.4567890123456789012345678901234567890) */
                 var expected_ = 123.45678901234568;
                 
                 /* Original: r.expr(123.4567890123456789012345678901234567890) */
                 var obtained = runOrCatch( r.expr(123.45678901234568) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #12
                 /* ExpectedOriginal: NUMBER */
                 var expected_ = "NUMBER";
                 
                 /* Original: r.expr(1).type_of() */
                 var obtained = runOrCatch( r.expr(1L).typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #13
                 /* ExpectedOriginal: 1 */
                 var expected_ = "1";
                 
                 /* Original: r.expr(1).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(1L).coerceTo("string") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #14
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(1).coerce_to('number') */
                 var obtained = runOrCatch( r.expr(1L).coerceTo("number") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #15
                 /* ExpectedOriginal: int_cmp(1) */
                 var expected_ = int_cmp(1L);
                 
                 /* Original: r.expr(1.0) */
                 var obtained = runOrCatch( r.expr(1.0) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #16
                 /* ExpectedOriginal: int_cmp(45) */
                 var expected_ = int_cmp(45L);
                 
                 /* Original: r.expr(45) */
                 var obtained = runOrCatch( r.expr(45L) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/number.yaml, #17
                 /* ExpectedOriginal: float_cmp(1.2) */
                 var expected_ = float_cmp(1.2);
                 
                 /* Original: r.expr(1.2) */
                 var obtained = runOrCatch( r.expr(1.2) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}
