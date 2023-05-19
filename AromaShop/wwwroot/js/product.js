var dataTable;
$(document).ready(function () {
    loadTable();
})

function loadTable() { 
    dataTable = $('#myTable').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'name', width: '20%' },
            { data: 'price', width: '10%' },
            { data: 'availability', width: '10%' },
            { data: 'category.name', width: '10%' },
            { data: 'brand', width: '10%' },
            {
                data: 'imagePath',
                'render': function (data) {
                    return `<img src="${data}" style="width: 100px; height: 100px;" alt=""/>`
                }, 'width': '15%' },
            { 
                data: 'id',
                'render': function (data) {
                    return `<div class="w-75 btn btn-group" role="group">
                                <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2 w-50"> <i class="bi bi-pencil-square"></i><br/>Edit</a>
                                <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger mx-2 w-50"> <i class="bi bi-trash-fill"></i><br/>Delete</a>
                            </div>`;
                },
                'width': '25%'
            }
        ]
    });
}