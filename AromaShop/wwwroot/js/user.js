var dataTable;

$(document).ready(function () {
    loadTable();
})

function loadTable() { 
    dataTable = $('#myTable').DataTable({
        "ajax": { url: '/admin/user/getall' },
        "columns": [
            { data: 'fullname', width: '20%' },
            { data: 'userName', width: '10%' },
            { data: 'email', width: '20%' },
            { data: 'role', width: '10%' },
            {
                data: 'avatarPath',
                'render': function (data) {
                    return `<img src="${data}" style="width: 100px; height: 100px;" alt="avatar image"/>`
                }, 'width': '15%' },
            {
                data: { id: 'id', lockoutEnd: 'lockoutEnd' },
                'render': function (data) {
                    let today = new Date().getTime();
                    let lockout = new Date(data.lockoutEnd).getTime();

                    if (lockout > today) {
                        return `<div class="w-75 btn btn-group" role="group">
                                    <a href="/admin/user/managerole?userId=${data.id}" class="btn btn-primary mx-2 w-50">
                                        <i class="bi bi-pencil-square"></i><br/>Edit
                                    </a>
                                    <a onclick="LockUnlock('${data.id}')" class="btn btn-warning text-white mx-2 w-50">
                                        <i class="bi bi-lock-fill"></i><br/>Lock
                                    </a>
                                </div>`;
                    }
                    else {
                        return `<div class="w-75 btn btn-group" role="group">
                                    <a href="/admin/user/managerole?userId=${data.id}" class="btn btn-primary mx-2 w-50">
                                        <i class="bi bi-pencil-square"></i><br/>Edit
                                    </a>
                                    <a onclick="LockUnlock('${data.id}')" class="btn btn-success text-white mx-2 w-50">
                                        <i class="bi bi-unlock-fill"></i><br/>Unlock
                                    </a>
                                </div>`;
                    }
                }, 'width': '25%'
            }
        ]
    });
}

function LockUnlock(id) {
    $.ajax({
        type: "POST",
        url: "/Admin/User/LockUnlock",
        data: JSON.stringify(id),
        contentType: "application/json",
        success: function (data) {
            if (data.success) {
                toastr.success(data.message);
                dataTable.ajax.reload();
            }
        }
    });
}