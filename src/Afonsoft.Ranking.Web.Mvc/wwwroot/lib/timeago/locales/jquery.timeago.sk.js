!function(n){"function"==typeof define&&define.amd?define(["jquery"],n):"object"==typeof module&&"object"==typeof module.exports?n(require("jquery")):n(jQuery)}(function(n){!function(){function o(n,o,e){return e[o>=0?0:2===e.length||n<5?1:2]}n.timeago.settings.strings={prefixAgo:"pred",prefixFromNow:"o",suffixAgo:null,suffixFromNow:null,seconds:function(n,e){return o(n,e,["menej ako minútou","menej ako minútu"])},minute:function(n,e){return o(n,e,["minútou","minútu"])},minutes:function(n,e){return o(n,e,["%d minútami","%d minúty","%d minút"])},hour:function(n,e){return o(n,e,["hodinou","hodinu"])},hours:function(n,e){return o(n,e,["%d hodinami","%d hodiny","%d hodín"])},day:function(n,e){return o(n,e,["%d dňom","%d deň"])},days:function(n,e){return o(n,e,["%d dňami","%d dni","%d dní"])},month:function(n,e){return o(n,e,["%d mesiacom","%d mesiac"])},months:function(n,e){return o(n,e,["%d mesiacmi","%d mesiace","%d mesiacov"])},year:function(n,e){return o(n,e,["%d rokom","%d rok"])},years:function(n,e){return o(n,e,["%d rokmi","%d roky","%d rokov"])}}}()});