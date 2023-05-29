var dataTable;
$(document).ready(function () {
    loadTable();
})

function loadTable() { 
    dataTable = $('#myTable').DataTable({
        "ajax": { url: '/admin/user/getall' },
        "columns": [
            { data: 'fullname', width: '15%' },
            { data: 'userName', width: '10%' },
            { data: 'email', width: '20%' },
            { data: 'role', width: '10%' },
            {
                data: 'avatarPath',
                'render': function (data) {
                    return `<img src="${data}" style="width: 100px; height: 100px;" alt="avatar image"/>`
                }, 'width': '25%' },
            { 
                data: 'id',
                'render': function (data) {
                    return `<div class="w-75 btn btn-group" role="group">
                                <a href="/admin/user/upsert?userId=${data}" class="btn btn-primary mx-2 w-50"> <i class="bi bi-pencil-square"></i><br/>Edit</a>
                                <a onClick=Delete('/admin/user/delete/${data}') class="btn btn-danger mx-2 w-50"> <i class="bi bi-trash-fill"></i><br/>Delete</a>
                            </div>`;
                }, 'width': '20%'
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