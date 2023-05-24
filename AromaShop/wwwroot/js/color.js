var dataTable;
$(document).ready(function () {
    loadTable();
})

function loadTable() { 
    dataTable = $('#myTable').DataTable({
        "ajax": { url: '/admin/color/getall' },
        "columns": [
            { data: 'name', width: '20%' },
            { data: 'code', width: '20%' },
            {
                data: 'imagePath',
                'render': function (data) {
                    return `<img src="${data}" style="width: 100px; height: 100px;" alt=""/>`
                }, 'width': '20%' },
            { 
                data: 'id',
                'render': function (data) {
                    return `<div class="w-75 btn btn-group" role="group">
                                <a href="/admin/color/upsert?id=${data}" class="btn btn-primary mx-2 w-50"> <i class="bi bi-pencil-square"></i><br/>Edit</a>
                                <a onClick=Delete('/admin/color/delete/${data}') class="btn btn-danger mx-2 w-50"> <i class="bi bi-trash-fill"></i><br/>Delete</a>
                            </div>`;
                }, 'width': '40%'
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}
