var oTable;
$(function () {
    Show();
    initClickEvents();
});

function initClickEvents() {
    $('#cbAll').change(function () {
        var bChecked = $(this).prop('checked');
        $('#list :checkbox').prop('checked', bChecked);
    });

    $('click', '#list :checkbox', function () {
        var bChecked = $(this).prop('checked');
        if (!bChecked && $('#cbAll').prop('checked') != bChecked)
            $('#cbAll').prop('checked', bChecked);
    });

    $('#btnAgreeAll,#btnRefusalAll').click(function () {
        var list = [];
        var checkedList1 = $('#list :checked');
        if (checkedList1.length == 0) {
            DialogAlert.alert('请选择要审批的记录。');
            return;
        }
        var btn = $(this);
        var btname = btn.attr('title');
        checkedList1.each(function () {
            var aPos = oTable.fnGetPosition($(this).parents('td')[0]);
            var curRoleIndex = aPos[0];
            var aData = oTable.fnGetData(curRoleIndex);
            //  return aData;
            var url = aData.Url;
            //alert(id);
            //var sn = id[2].split('=')[1];
            var sn = url.split('SN=')[1].split('&')[0];
            list.push({ SN: sn, ProcessNextName: btname, Opinion: btname });
        });

        $.ajax({
            type: "post",
            url: "/api/vendortasks",
            data: JSON.stringify(list),
            success: function (data) {
                Show();
            },
            error: function (data) {
            },
            dataType: "json",
            contentType: "application/json"
        });
    });
    //$('#btnRefusalAll').click(function () {
    //    var listIds = [];
    //    var checkedList1 = $('#list :checked');
    //    checkedList1.each(function () {
    //        var id = $(this).parent().next().text().split('&');
    //        var sn = id[2].split('=')[1];
    //        var ids = id[0].split('=')[1];
    //        var btname = $('#btnAgreeAll').val();
    //        listIds.push({ SN: sn, ProcessNextName: btname, Opinion: btname });
    //    });
    //    $.ajax({
    //        type: "post",
    //        url: "/api/vendortasks",
    //        data: JSON.stringify(list),
    //        success: function (data) {
    //            Show();
    //        },
    //        error: function (data) {

    //        },
    //        dataType: "json",
    //        contentType: "application/json"
    //    });
    //});
}

function Show() {
    oTable = $('#list').dataTable({
        "sDom": 'lrtip',
        "bProcessing": true,
        "bServerSide": false,
        "bFilter": true,
        'bAutoWidth': true,
        "sScrollY": "325px",
        //'sScrollYInner': "700px",
        'bDestroy': true,
        'aaSorting': [[3, "desc"]],
        "sScrollX": "100%",
        "sScrollXInner": "100%",
        "sAjaxDataProp": "Results",//保存列表的字段
        "sPaginationType": "full_numbers",
        "sAjaxSource": "/api/VendorTasks/" + iRoleMd,
        //"fnServerData": DataTablesOption.fnServerData_fillEmpty,
        "aoColumns": [
               {
                   "mData": null,
                   "sClass": "center",
                   "bSortable": false,
                   "fnRender": function (obj) {
                       var link = '';
                       if (obj.aData.Url) {
                           link = '<input type="checkbox" />';
                       }
                       return link;
                   }
               },
                // { "mData": "Url", 'sClass': 'hidden' }, //,'bVisible':false
                        {
                            "mData": null, "fnRender": function (obj) {
                                var link = '';
                                if (obj.aData.Url) {
                                    link = '<a href="' + obj.aData.Url + '">' + obj.aData.Title + '</a>';
                                }
                                return link;
                            }
                        },
                        { "mData": "CreateUser", 'sDefaultContent': '' },
                        {
                            "mData": "StartDate", 'sDefaultContent': '', "fnRender": function (obj) {
                                return PageCommon.formatTime(obj.aData.StartDate);
                            }
                        }
        ],
        "fnDrawCallback": function (oSettings) {
            $('div.dataTables_scrollHeadInner').css('width', '100%');//.css('padding-right', '0px');
            $('table.dataTable').css('width', '100%');
            var pageIndex = oSettings._iDisplayStart / oSettings._iDisplayLength + 1;
            $('div.dataTables_paginate > span').html('第 <input id="txtSetPage" type="text" value="' + pageIndex + '" style="width:3em; text-align:center;"> 页');
            $('#txtSetPage').keypress(function () {
                if (event.keyCode == 13) {
                    var newPage = parseInt($('#txtSetPage').val());
                    if (newPage > 0)
                        oTable.fnPageChange(newPage - 1);
                }
            });
            //PageCommon.setPageHeight();
        },
        'fnInitComplete': function (oSettings, json) {
            $('a.first').html('<img alt="" src="/Images/first.png" />');
            $('a.previous').html('<img alt="" src="/Images/prev.png" />');
            $('a.next').html('<img alt="" src="/Images/next.png" />');
            $('a.last').html('<img alt="" src="/Images/last.png" />');

        },
        "oLanguage": {
            "sUrl": "/Scripts/DataTables-1.9.4/media/language/dataTables.zh-CN.txt"
        }
    });
}