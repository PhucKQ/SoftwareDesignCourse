var dataTable;
$(document).ready(function () {
    var url = window.location.search;
    if (url.includes("inprocess")) {
        loadTable("inprocess");
    } else {
        if (url.includes("completed")) {
            loadTable("completed");
        } else {
            if (url.includes("pending")) {
                loadTable("pending");
            } else {
                if (url.includes("approved")) {
                    loadTable("approved");
                } else {
                    loadTable("all");
                }
            }
        }
    }
});

function loadTable(status) { 
    dataTable = $('#myTable').DataTable({
        "ajax": { url: '/admin/order/getall?status=' + status },
        "columns": [
            { data: 'id', width: '5%' },
            { data: 'firstName', width: '20%' },
            { data: 'phoneNumber', width: '20%' },
            { data: 'email', width: '25%' },
            { data: 'orderStatus', width: '10%' },
            { data: 'orderTotal','width': '10%' },
            { 
                data: 'id',
                'render': function (data) {
                    return `<div class="w-75 btn btn-group" role="group">
                                <a href="/admin/order/details?orderId=${data}" class="btn btn-primary mx-2 w-50"> <i class="bi bi-pencil-square"></i></a>
                            </div>`;
                },
                'width': '10%'
            }
        ]
    });
}