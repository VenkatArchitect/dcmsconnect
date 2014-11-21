﻿$(document).ready(function () {
    "use strict";
    $('#freezeModal').on('show.bs.modal', function (e) {
        //alert($(e.relatedTarget).data('bucketid'));
        $('#hfBucketid', e.delegateTarget).val($(e.relatedTarget).data('bucketid'));
    }).on('click', 'button:not([data-dismiss])', function (e) {
        //alert('submit');
        $('form', e.delegateTarget).trigger('submit');
    });

});



/*
Provides method and event to Increase or Decrease priority bucket
*/
//$.widget("custom.bucketmodel", {
//    options: {
//      //priorityIncreased: null
//    },
//    // the constructor
//    _create: function () {
//        this._on({            
//            'click div.div-bucket >span.ui-icon-arrowthick-1-s,div.div-bucket >span.ui-icon-arrowthick-1-n': function (e) {
//                this._doChangePriority(e.target);
//            }
//        });
//    },
//    _doChangePriority: function (icon) {
//        //Increase or Decrease the pick wave priority
//        $.ajax($(icon).closest('div.div-bucket').attr($(icon).is('.ui-icon-arrowthick-1-n') ? 'data-increase-priority-url' : 'data-decrease-priority-url'), {
//            cache: false,
//            type: 'POST',
//            context: icon,
//            beforeSend: function (jqXHR, settings) {
//                $(settings.context).closest('div.div-bucket').addClass('ui-state-highlight');
//            }
//        }).done(function (data, textStatus, jqXHR) {
//            $(this).closest('div.div-bucket').removeClass('ui-state-highlight').find('span.span-Priority').html(data);
//        }).error(function (data, textStatus, jqXHR) {
//            $(this).closest('div.div-bucket').removeClass('ui-state-highlight');
//            alert(data.responseText);
//        });
//    },    
//    increasePriority: function () {
//        var $icon = $('span.ui-icon-arrowthick-1-n', this.element);
//        this._doChangePriority($icon[0]);
//    },
//    decreasePriority: function () {
//        var $icon = $('span.ui-icon-arrowthick-1-s', this.element);
//        this._doChangePriority($icon[0]);
//    }
//});
