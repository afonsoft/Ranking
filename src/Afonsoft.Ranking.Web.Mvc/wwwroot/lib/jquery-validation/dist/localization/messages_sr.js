!function(e){"function"==typeof define&&define.amd?define(["jquery","../jquery.validate"],e):"object"==typeof module&&module.exports?module.exports=e(require("jquery")):e(jQuery)}(function(e){return e.extend(e.validator.messages,{required:"Поље је обавезно.",remote:"Средите ово поље.",email:"Унесите исправну и-мејл адресу.",url:"Унесите исправан URL.",date:"Унесите исправан датум.",dateISO:"Унесите исправан датум (ISO).",number:"Унесите исправан број.",digits:"Унесите само цифе.",creditcard:"Унесите исправан број кредитне картице.",equalTo:"Унесите исту вредност поново.",extension:"Унесите вредност са одговарајућом екстензијом.",maxlength:e.validator.format("Унесите мање од {0} карактера."),minlength:e.validator.format("Унесите барем {0} карактера."),rangelength:e.validator.format("Унесите вредност дугачку између {0} и {1} карактера."),range:e.validator.format("Унесите вредност између {0} и {1}."),max:e.validator.format("Унесите вредност мању или једнаку {0}."),min:e.validator.format("Унесите вредност већу или једнаку {0}."),step:e.validator.format("Унесите вредност која је умножак броја {0}.")}),e});