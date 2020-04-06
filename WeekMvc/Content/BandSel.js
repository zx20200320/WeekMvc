$(function () {
    //绑定分类
    $.ajax({
        url: "http://localhost:8481/api/Good/BandType",//api的路径
        success: function (d) {
            $(d).each(function () {
                var op = '<option value="' + this.Id + '">' + this.TypeName + '</option>';
                $("#typeId").append(op);//typeId表示下拉列表控件的id
            })
        }
    })
    //绑定供应商
    $.ajax({
        url: "http://localhost:8481/api/Good/BandSupplier",
        success: function (d) {
            $(d).each(function () {
                var op = '<option value="' + this.Id + '">' + this.SupplierName + '</option>';
                $("#SupplierId").append(op);//SupplierId表示下拉列表控件的id
            })
        }
    })
})