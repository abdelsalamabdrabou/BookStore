let dataTable = $("#usersTable").DataTable({
    "ajax": {
        "url": "/Admin/Users/GetUsers",
        "type": "GET"
    },
    "columns": [
        { "data": "userId", "width": "25%" },
        { "data": "username" },
        { "data": "email" },
        {
            "data": "userId",
            "render": function (data) {
                return `
                    <div class="btn-group" role="group">
                        <button id="btnGroupDrop1" type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Actions
                        </button>
                        <div class="dropdown-menu" aria-labelledby="btnGroupDrop1">
                            <a class="dropdown-item" href="/Admin/Users/ManageRoles?id=${data}">Manage Roles</a>
                            <a class="dropdown-item" href="/Admin/Roles">Delete</a>
                        </div>
                    </div>
                `;
            }
        }
    ]
})