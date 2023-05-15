using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AromaShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataToProduct_ProductColor_ProductSpecification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Availability", "BrandId", "CategoryId", "Description", "ImagePath", "Name", "OverallReview", "Price", "ReviewCount", "Summary", "ThumbnailPath" },
                values: new object[,]
                {
                    { 1, false, 4, 7, "<p>Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.</p><p>Duis bibendum. Morbi non quamnec dui luctus rutrum. Nulla tellus.</p>", "/img/product/product7.png", "Savory", 2.6699999999999999, 63.810000000000002, 3, "Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.", "/img/product/product-sm-3.png" },
                    { 2, false, 4, 4, "<p>Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.</p><p>Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo,sollicitudin ut, suscipit a, feugiat et, eros.</p><p>Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.</p><p>In congue. Etiam justo. Etiam pretium iaculis justo.</p>", "/img/product/product8.png", "Zucchini - Green", 1.6699999999999999, 6.5599999999999996, 3, "Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.", "/img/product/product-sm-7.png" },
                    { 3, false, 2, 7, "<p>Phasellus in felis. Donec semper sapien a libero. Nam dui.</p><p>Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.</p><p>Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.</p>", "/img/product/product1.png", "Tart - Butter Plain Squares", 2.3300000000000001, 95.709999999999994, 3, "ulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.", "/img/product/product-sm-1.png" },
                    { 4, false, 2, 4, "<p>Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.</p><p>Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus.</p>", "/img/product/product5.png", "Doilies - 12, Paper", 1.6699999999999999, 89.489999999999995, 3, "Fusce consequat. Nulla nisl. Nunc nisl.", "/img/product/product-sm-5.png" },
                    { 5, true, 4, 1, "<p>Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.</p><p>Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.</p><p>Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.</p>", "/img/product/product7.png", "Trout - Hot Smkd, Dbl Fillet", 3.6699999999999999, 22.16, 3, "Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.", "/img/product/product-sm-1.png" },
                    { 6, false, 4, 2, "<p>Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.</p><p>Phasellus in felis. Donec semper sapien a libero. Nam dui.</p>", "/img/product/product3.png", "Ranchero - Primerba, Paste", 3.0, 19.039999999999999, 3, "In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.", "/img/product/product-sm-1.png" },
                    { 7, false, 1, 6, "<p>Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.</p><p>Sed ante. Vivamus tortor. Duis mattis egestas metus.</p><p>Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.</p><p>Quisque id justosit amet sapien dignissim vestibulum. Vestibulum ante ipsum primisin faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.</p>", "/img/product/product5.png", "Beef - Tenderloin", 3.6699999999999999, 51.310000000000002, 3, "Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.", "/img/product/product-sm-1.png" },
                    { 8, false, 2, 7, "<p>Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.</p><p>Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus.</p><p>Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p><p>Etiamvel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.</p><p>Praesent id massa id nisl venenatis lacinia. Aenean sit ametjusto. Morbi ut odio.</p>", "/img/product/product2.png", "Crab - Soft Shell", 2.6699999999999999, 12.529999999999999, 3, "Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.", "/img/product/product-sm-5.png" },
                    { 9, true, 2, 5, "<p>Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.</p><p>Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus.</p><p>Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p><p>Etiamvel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.</p>", "/img/product/product4.png", "Shiro Miso", 2.6699999999999999, 58.689999999999998, 3, "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.", "/img/product/product-sm-3.png" },
                    { 10, true, 1, 2, "<p>Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.</p><p>Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.</p><p>Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscinglorem, vitae mattis nibh ligula nec sem.</p><p>Duis aliquam convallisnunc. Proin at turpis a pede posuere nonummy. Integer non velit.</p>", "/img/product/product1.png", "Wine - Segura Viudas Aria Brut", 4.0, 94.890000000000001, 3, "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.", "/img/product/product-sm-5.png" },
                    { 11, false, 2, 4, "<p>Phasellus in felis. Donec semper sapien a libero. Nam dui.</p><p>Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.</p><p>Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.</p><p>Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.</p>", "/img/product/product6.png", "Juice - Pineapple, 48 Oz", 3.3300000000000001, 24.48, 3, "In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.", "/img/product/product-sm-7.png" },
                    { 12, true, 4, 4, "<p>Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.</p>", "/img/product/product1.png", "Filling - Mince Meat", 2.6699999999999999, 51.100000000000001, 3, "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.", "/img/product/product-sm-5.png" },
                    { 13, true, 5, 2, "<p>Vestibulum quam sapien, varius ut, blandit non, interdum in,ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.</p>", "/img/product/product7.png", "Pears - Fiorelle", 3.0, 19.25, 3, "Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.", "/img/product/product-sm-5.png" },
                    { 14, true, 2, 7, "<p>Sed ante. Vivamus tortor. Duis mattis egestas metus.</p><p>Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.</p><p>Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.</p>", "/img/product/product5.png", "Wine - Red, Black Opal Shiraz", 3.3300000000000001, 3.4399999999999999, 3, "Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.", "/img/product/product-sm-7.png" },
                    { 15, false, 2, 1, "<p>Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.</p><p>Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.</p><p>Fusce consequat. Nulla nisl. Nunc nisl.</p>", "/img/product/product8.png", "Pie Filling - Pumpkin", 3.0, 67.510000000000005, 3, "Fusce consequat. Nulla nisl. Nunc nisl.", "/img/product/product-sm-4.png" },
                    { 16, false, 4, 2, "<p>Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut,rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem.</p>", "/img/product/product5.png", "Cheese - Mozzarella, Buffalo", 3.3300000000000001, 73.989999999999995, 3, "Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.", "/img/product/product-sm-4.png" },
                    { 17, false, 1, 3, "<p>Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut,rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem.</p><p>Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.</p><p>Pellentesque at nulla. Suspendisse potenti.Cras in purus eu magna vulputate luctus.</p>", "/img/product/product4.png", "Gatorade - Fruit Punch", 1.3300000000000001, 63.840000000000003, 3, "Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuerecubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.", "/img/product/product-sm-5.png" },
                    { 18, false, 1, 5, "<p>Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.</p><p>Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.</p><p>Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudinmi, sit amet lobortis sapien sapien non mi. Integer ac neque.</p><p>Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.</p>", "/img/product/product4.png", "Beef - Bones, Cut - Up", 2.6699999999999999, 59.659999999999997, 3, "Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.", "/img/product/product-sm-6.png" },
                    { 19, false, 5, 5, "<p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus.</p><p>Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.</p><p>Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.</p>", "/img/product/product6.png", "Bread - Roll, Canadian Dinner", 4.0, 14.01, 3, "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat.", "/img/product/product-sm-3.png" },
                    { 20, false, 4, 4, "<p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus.</p><p>Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.</p><p>Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.</p><p>Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.</p><p>Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.</p>", "/img/product/product7.png", "Milk - Condensed", 3.0, 12.880000000000001, 3, "In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.", "/img/product/product-sm-8.png" },
                    { 21, true, 1, 7, "<p>Maecenas leo odio, condimentum id, luctus nec, molestie sed,justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.</p><p>Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsumprimis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.</p><p>Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam nonmauris.</p>", "/img/product/product5.png", "Beans - French", 4.3300000000000001, 89.230000000000004, 3, "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.", "/img/product/product-sm-8.png" },
                    { 22, true, 3, 1, "<p>Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.</p><p>Curabitur in libero ut massa volutpatconvallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.</p><p>Phasellus sit amet erat.Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.</p><p>Proin eu mi. Nulla ac enim. In tempor, turpis nec euismod scelerisque,quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.</p>", "/img/product/product8.png", "Cheese - Goat With Herbs", 2.6699999999999999, 96.489999999999995, 3, "Vestibulum quam sapien, varius ut, blandit non, interdum in,ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.", "/img/product/product-sm-1.png" },
                    { 23, true, 2, 5, "<p>Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.</p>", "/img/product/product4.png", "Cheese - Manchego, Spanish", 4.3300000000000001, 71.519999999999996, 3, "Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.", "/img/product/product-sm-5.png" },
                    { 24, true, 4, 1, "<p>Maecenas leo odio, condimentum id, luctus nec, molestie sed,justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.</p><p>Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsumprimis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.</p><p>Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam nonmauris.</p>", "/img/product/product4.png", "Muffin Hinge Container 6", 3.0, 89.75, 3, "In hac habitasse platea dictumst. Morbi vestibulum, velit idpretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.", "/img/product/product-sm-5.png" },
                    { 25, true, 1, 1, "<p>Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.</p><p>Duis bibendum. Morbi non quamnec dui luctus rutrum. Nulla tellus.</p><p>In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.</p>", "/img/product/product3.png", "Pepper - Gypsy Pepper", 2.6699999999999999, 89.629999999999995, 3, "Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.", "/img/product/product-sm-5.png" },
                    { 26, false, 1, 3, "<p>Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.</p><p>Phasellus in felis. Donec semper sapien a libero. Nam dui.</p><p>Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Utat dolor quis odio consequat varius.</p><p>Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.</p><p>Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nullaelit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.</p>", "/img/product/product8.png", "Muffin - Mix - Mango Sour Cherry", 3.0, 7.79, 3, "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.", "/img/product/product-sm-4.png" },
                    { 27, true, 3, 5, "<p>Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.</p><p>Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat.</p><p>Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.</p>", "/img/product/product4.png", "Beer - Labatt Blue", 2.3300000000000001, 62.659999999999997, 3, "In hac habitasse platea dictumst. Morbi vestibulum, velit idpretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo.", "/img/product/product-sm-5.png" },
                    { 28, true, 2, 1, "<p>Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.</p><p>Praesent id massa id nisl venenatis lacinia. Aenean sit amet justo. Morbi ut odio.</p><p>Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.</p><p>Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapienin sapien iaculis congue. Vivamus metus arcu, adipiscing molestie,hendrerit at, vulputate vitae, nisl.</p><p>Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.</p>", "/img/product/product1.png", "Cheese - Blue", 3.0, 74.040000000000006, 3, "Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", "/img/product/product-sm-3.png" },
                    { 29, false, 1, 7, "<p>Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.</p><p>Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.</p><p>Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla. Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.</p>", "/img/product/product1.png", "Chick Peas - Canned", 3.3300000000000001, 74.129999999999995, 3, "Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.", "/img/product/product-sm-6.png" },
                    { 30, true, 5, 7, "<p>Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.</p>", "/img/product/product2.png", "Apple - Northern Spy", 3.3300000000000001, 48.539999999999999, 3, "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.", "/img/product/product-sm-5.png" },
                    { 31, true, 2, 6, "<p>Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.</p><p>Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem.</p>", "/img/product/product5.png", "Versatainer Nc - 8288", 5.0, 15.6, 2, "In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.", "/img/product/product-sm-1.png" },
                    { 32, true, 4, 1, "<p>Pellentesque at nulla. Suspendisse potenti. Cras in purus eumagna vulputate luctus.</p><p>Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>", "/img/product/product1.png", "Capers - Ox Eye Daisy", 4.0, 34.68, 2, "Cras mi pede, malesuada in, imperdiet et, commodo vulputate,justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", "/img/product/product-sm-1.png" },
                    { 33, false, 4, 7, "<p>Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.</p>", "/img/product/product3.png", "Toamtoes 6x7 Select", 3.0, 73.739999999999995, 2, "Phasellus in felis. Donec semper sapien a libero. Nam dui.", "/img/product/product-sm-2.png" },
                    { 34, true, 5, 2, "<p>Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuerecubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.</p><p>Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.</p><p>In congue. Etiam justo. Etiam pretium iaculis justo.</p><p>In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.</p>", "/img/product/product7.png", "Pork - Back Ribs", 2.5, 35.659999999999997, 2, "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros. Suspendisse accumsan tortor quis turpis.", "/img/product/product-sm-8.png" },
                    { 35, false, 4, 7, "<p>Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.</p><p>Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat.</p><p>Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.</p><p>Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placera</p>", "/img/product/product3.png", "Beer - True North Lager", 4.0, 42.659999999999997, 2, "Maecenas leo odio, condimentum id, luctus nec, molestie sed,justo. Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.", "/img/product/product-sm-2.png" }
                });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "ColorId", "ProductId", "ImagePath" },
                values: new object[,]
                {
                    { 2, 1, "/img/product/product5.png" },
                    { 5, 1, "/img/product/product1.png" },
                    { 1, 2, "/img/product/product3.png" },
                    { 4, 2, "/img/product/product4.png" },
                    { 1, 3, "/img/product/product1.png" },
                    { 3, 3, "/img/product/product8.png" },
                    { 1, 4, "/img/product/product5.png" },
                    { 3, 4, "/img/product/product4.png" },
                    { 4, 4, "/img/product/product2.png" },
                    { 5, 4, "/img/product/product5.png" },
                    { 2, 5, "/img/product/product5.png" },
                    { 3, 6, "/img/product/product2.png" },
                    { 4, 6, "/img/product/product2.png" },
                    { 5, 6, "/img/product/product4.png" },
                    { 1, 7, "/img/product/product8.png" },
                    { 2, 7, "/img/product/product3.png" },
                    { 1, 8, "/img/product/product6.png" },
                    { 3, 8, "/img/product/product7.png" },
                    { 4, 8, "/img/product/product1.png" },
                    { 5, 8, "/img/product/product1.png" },
                    { 5, 9, "/img/product/product5.png" },
                    { 1, 11, "/img/product/product5.png" },
                    { 5, 11, "/img/product/product7.png" },
                    { 2, 12, "/img/product/product3.png" },
                    { 3, 12, "/img/product/product1.png" },
                    { 2, 13, "/img/product/product6.png" },
                    { 3, 13, "/img/product/product5.png" },
                    { 3, 14, "/img/product/product3.png" },
                    { 4, 14, "/img/product/product5.png" },
                    { 5, 14, "/img/product/product8.png" },
                    { 3, 15, "/img/product/product4.png" },
                    { 2, 16, "/img/product/product7.png" },
                    { 5, 16, "/img/product/product3.png" },
                    { 1, 17, "/img/product/product4.png" },
                    { 5, 17, "/img/product/product5.png" },
                    { 1, 18, "/img/product/product3.png" },
                    { 2, 19, "/img/product/product5.png" },
                    { 3, 19, "/img/product/product5.png" },
                    { 5, 19, "/img/product/product8.png" },
                    { 4, 20, "/img/product/product4.png" },
                    { 5, 21, "/img/product/product1.png" },
                    { 3, 22, "/img/product/product1.png" },
                    { 2, 23, "/img/product/product6.png" },
                    { 4, 24, "/img/product/product2.png" },
                    { 1, 25, "/img/product/product2.png" },
                    { 4, 25, "/img/product/product8.png" },
                    { 5, 25, "/img/product/product3.png" },
                    { 4, 26, "/img/product/product1.png" },
                    { 5, 26, "/img/product/product3.png" },
                    { 3, 27, "/img/product/product7.png" },
                    { 5, 27, "/img/product/product1.png" },
                    { 2, 28, "/img/product/product2.png" },
                    { 4, 28, "/img/product/product1.png" },
                    { 1, 29, "/img/product/product8.png" },
                    { 2, 29, "/img/product/product4.png" },
                    { 3, 29, "/img/product/product7.png" },
                    { 4, 29, "/img/product/product7.png" },
                    { 5, 29, "/img/product/product8.png" },
                    { 1, 30, "/img/product/product1.png" },
                    { 5, 30, "/img/product/product7.png" },
                    { 1, 31, "/img/product/product5.png" },
                    { 4, 31, "/img/product/product1.png" },
                    { 3, 32, "/img/product/product3.png" },
                    { 4, 32, "/img/product/product3.png" },
                    { 4, 33, "/img/product/product2.png" },
                    { 1, 34, "/img/product/product6.png" },
                    { 2, 34, "/img/product/product4.png" },
                    { 4, 34, "/img/product/product2.png" },
                    { 1, 35, "/img/product/product3.png" },
                    { 4, 35, "/img/product/product4.png" },
                    { 5, 35, "/img/product/product3.png" }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
                columns: new[] { "ProductId", "SpecificationId", "Description" },
                values: new object[,]
                {
                    { 1, 1, "duis ac nibh" },
                    { 1, 2, "non sodales" },
                    { 1, 3, "quam" },
                    { 1, 4, "mauris" },
                    { 1, 5, "sapien arna pretium" },
                    { 1, 6, "diam neque" },
                    { 1, 7, "eleifend" },
                    { 2, 1, "tristique in" },
                    { 2, 2, "duis" },
                    { 2, 3, "at lorem" },
                    { 2, 4, "amet eros" },
                    { 2, 5, "ligula" },
                    { 2, 6, "nunc" },
                    { 2, 7, "orci eget orci" },
                    { 3, 1, "quam sapien" },
                    { 3, 2, "eget nunc" },
                    { 3, 3, "dictumst" },
                    { 3, 4, "quis" },
                    { 3, 5, "magna ac consequat" },
                    { 3, 6, "lacus" },
                    { 3, 7, "malesuada in" },
                    { 4, 1, "elit ac" },
                    { 4, 2, "nisi at nibh" },
                    { 4, 3, "lorem ipsum" },
                    { 4, 4, "est" },
                    { 4, 5, "justo pellentesque" },
                    { 4, 6, "volutpat eleifend donec" },
                    { 4, 7, "nonummy maecenas" },
                    { 5, 1, "vestibulum ac est" },
                    { 5, 2, "quis lectus" },
                    { 5, 3, "congue vivamus" },
                    { 5, 4, "justo" },
                    { 5, 5, "pede malesuada" },
                    { 5, 6, "ut erat id" },
                    { 5, 7, "lorem integer tincidunt" },
                    { 6, 1, "non sodales sed" },
                    { 6, 2, "est quam pharetra" },
                    { 6, 3, "blandit" },
                    { 6, 4, "quam nec dui" },
                    { 6, 5, "nisi" },
                    { 6, 6, "pede" },
                    { 6, 7, "nisl venenatis lacinia" },
                    { 7, 1, "turpis a" },
                    { 7, 2, "orci vehicula" },
                    { 7, 3, "ipsum dolor sit" },
                    { 7, 4, "nulla sed" },
                    { 7, 5, "sed tristique in" },
                    { 7, 6, "porttitor pede" },
                    { 7, 7, "enim" },
                    { 8, 1, "placera ante nulla" },
                    { 8, 2, "venenatis turpis enim" },
                    { 8, 3, "sit amet justo" },
                    { 8, 4, "est donec odio" },
                    { 8, 5, "hac" },
                    { 8, 6, "aenean auctor gravida" },
                    { 8, 7, "et" },
                    { 9, 1, "sed" },
                    { 9, 2, "non" },
                    { 9, 3, "ut" },
                    { 9, 4, "mattis egestas metus" },
                    { 9, 5, "ornare" },
                    { 9, 6, "vel" },
                    { 9, 7, "nulla elit" },
                    { 10, 1, "non" },
                    { 10, 2, "nunc nisl" },
                    { 10, 3, "vulputate ut" },
                    { 10, 4, "ultrices vel" },
                    { 10, 5, "molestie nibh" },
                    { 10, 6, "ac diam" },
                    { 10, 7, "pharetra magna" },
                    { 11, 1, "aliquam augue quam" },
                    { 11, 2, "pede posuere" },
                    { 11, 3, "nibh" },
                    { 11, 4, "feugiat non" },
                    { 11, 5, "libero ut" },
                    { 11, 6, "nisl nunc rhoncus" },
                    { 11, 7, "ultrices" },
                    { 12, 1, "vivamus vestibulum" },
                    { 12, 2, "vel pede" },
                    { 12, 3, "adipiscing" },
                    { 12, 4, "diam nam" },
                    { 12, 5, "risus" },
                    { 12, 6, "amet" },
                    { 12, 7, "dictumst morbi vestibulum" },
                    { 13, 1, "dui nec nisi" },
                    { 13, 2, "amet sapien" },
                    { 13, 3, "luctus et ultrices" },
                    { 13, 4, "nunc" },
                    { 13, 5, "diam" },
                    { 13, 6, "sapien in" },
                    { 13, 7, "vulputate elementum nullam" },
                    { 14, 1, "porttitor" },
                    { 14, 2, "eget eros elementum" },
                    { 14, 3, "nulla" },
                    { 14, 4, "risus" },
                    { 14, 5, "pede" },
                    { 14, 6, "in hac" },
                    { 14, 7, "arcu libero" },
                    { 15, 1, "vulputate vitae nisl" },
                    { 15, 2, "ut nunc" },
                    { 15, 3, "fermentum" },
                    { 15, 4, "sem duis" },
                    { 15, 5, "enim" },
                    { 15, 6, "dolor sit amet" },
                    { 15, 7, "odio in" },
                    { 16, 1, "neque vestibulum" },
                    { 16, 2, "consectetuer eget" },
                    { 16, 3, "justo morbi ut" },
                    { 16, 4, "congue" },
                    { 16, 5, "maecenas ut" },
                    { 16, 6, "curae" },
                    { 16, 7, "orci pede" },
                    { 17, 1, "luctus et" },
                    { 17, 2, "non velit" },
                    { 17, 3, "vestibulum ante" },
                    { 17, 4, "ac" },
                    { 17, 5, "morbi vel lectus" },
                    { 17, 6, "sapien iaculis congue" },
                    { 17, 7, "nec molestie" },
                    { 18, 1, "donec pharetra" },
                    { 18, 2, "duis bibendum morbi" },
                    { 18, 3, "nullam sit amet" },
                    { 18, 4, "in libero" },
                    { 18, 5, "interdum venenatis" },
                    { 18, 6, "quis turpis eget" },
                    { 18, 7, "felis donec semper" },
                    { 19, 1, "tincidunt" },
                    { 19, 2, "felis fusce" },
                    { 19, 3, "nisl venenatis" },
                    { 19, 4, "ante ipsum" },
                    { 19, 5, "sapien in sapien" },
                    { 19, 6, "lorem quisque" },
                    { 19, 7, "sit amet erat" },
                    { 20, 1, "odio curabitur" },
                    { 20, 2, "odio porttitor id" },
                    { 20, 3, "lacus" },
                    { 20, 4, "id ligula" },
                    { 20, 5, "bibendum" },
                    { 20, 6, "nulla tempus" },
                    { 20, 7, "turpis enim blandit" },
                    { 21, 1, "vestibulum" },
                    { 21, 2, "nam" },
                    { 21, 3, "metus sapien" },
                    { 21, 4, "diam" },
                    { 21, 5, "risus" },
                    { 21, 6, "tristique tortor" },
                    { 21, 7, "luctus et" },
                    { 22, 1, "pulvinar sed nisl" },
                    { 22, 2, "sociis natoque" },
                    { 22, 3, "nulla dapibus" },
                    { 22, 4, "a suscipit" },
                    { 22, 5, "vestibulum eget vulputate" },
                    { 22, 6, "volutpat" },
                    { 22, 7, "iaculis congue vivamus" },
                    { 23, 1, "parturient" },
                    { 23, 2, "eros" },
                    { 23, 3, "id mauris vulputate" },
                    { 23, 4, "congue" },
                    { 23, 5, "pulvinar" },
                    { 23, 6, "diam in magna" },
                    { 23, 7, "ultrices phasellus id" },
                    { 24, 1, "parturient montes nascetur" },
                    { 24, 2, "justo in" },
                    { 24, 3, "nulla" },
                    { 24, 4, "proin leo odio" },
                    { 24, 5, "nulla nunc purus" },
                    { 24, 6, "eget" },
                    { 24, 7, "velit vivamus vel" },
                    { 25, 1, "arcu" },
                    { 25, 2, "nec" },
                    { 25, 3, "non mi integer" },
                    { 25, 4, "adipiscing molestie" },
                    { 25, 5, "morbi" },
                    { 25, 6, "justo sit amet" },
                    { 25, 7, "vehicula condimentum" },
                    { 26, 1, "sed lacus" },
                    { 26, 2, "diam" },
                    { 26, 3, "aenean" },
                    { 26, 4, "lobortis est phasellus" },
                    { 26, 5, "nisl aenean lectus" },
                    { 26, 6, "non velit nec" },
                    { 26, 7, "erat id mauris" },
                    { 27, 1, "leo odio" },
                    { 27, 2, "dolor sit amet" },
                    { 27, 3, "libero" },
                    { 27, 4, "massa volutpat convallis" },
                    { 27, 5, "orci pede" },
                    { 27, 6, "arcu libero" },
                    { 27, 7, "mattis nibh" },
                    { 28, 1, "imperdiet sapien urna" },
                    { 28, 2, "neque" },
                    { 28, 3, "dui" },
                    { 28, 4, "lobortis est" },
                    { 28, 5, "vel enim" },
                    { 28, 6, "feugiat non" },
                    { 28, 7, "eu orci" },
                    { 29, 1, "justo" },
                    { 29, 2, "ipsum" },
                    { 29, 3, "molestie sed justo" },
                    { 29, 4, "vitae" },
                    { 29, 5, "nec" },
                    { 29, 6, "sed lacus morbi" },
                    { 29, 7, "ornare consequat" },
                    { 30, 1, "nec nisi" },
                    { 30, 2, "vivamus" },
                    { 30, 3, "tellus semper interdum" },
                    { 30, 4, "dapibus duis at" },
                    { 30, 5, "elementum pellentesque quisque" },
                    { 30, 6, "luctus nec" },
                    { 30, 7, "etiam" },
                    { 31, 1, "sed accumsan" },
                    { 31, 2, "varius ut" },
                    { 31, 3, "sodales" },
                    { 31, 4, "eros viverra" },
                    { 31, 5, "tempus vivamus" },
                    { 31, 6, "tristique fusce" },
                    { 31, 7, "amet" },
                    { 32, 1, "vel" },
                    { 32, 2, "convallis tortor risus" },
                    { 32, 3, "velit vivamus vel" },
                    { 32, 4, "non" },
                    { 32, 5, "metus" },
                    { 32, 6, "sit amet" },
                    { 32, 7, "vitae nisi nam" },
                    { 33, 1, "vivamus" },
                    { 33, 2, "auctor gravida sem" },
                    { 33, 3, "at" },
                    { 33, 4, "at" },
                    { 33, 5, "aliquam quis turpis" },
                    { 33, 6, "sit amet eleifend" },
                    { 33, 7, "quam sapien" },
                    { 34, 1, "quis orci" },
                    { 34, 2, "maecenas tincidunt lacus" },
                    { 34, 3, "pede morbi porttitor" },
                    { 34, 4, "lorem vitae" },
                    { 34, 5, "purus phasellus" },
                    { 34, 6, "amet diam" },
                    { 34, 7, "non lectus" },
                    { 35, 1, "ante" },
                    { 35, 2, "massa volutpat" },
                    { 35, 3, "dolor sit amet" },
                    { 35, 4, "maecenas pulvinar lobortis" },
                    { 35, 5, "aenean lectus pellentesque" },
                    { 35, 6, "quis lectus" },
                    { 35, 7, "etiam" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 21 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 25 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 25 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 26 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 26 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 27 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 27 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 28 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 28 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 29 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 29 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 29 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 29 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 30 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 30 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 31 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 3, 32 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 32 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 33 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 2, 34 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 34 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 4, 35 });

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumns: new[] { "ColorId", "ProductId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 23, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 23, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 23, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 26, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 27, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 27, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 28, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 29, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 29, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 29, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 29, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 30, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 30, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 31, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 31, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 31, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 31, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 31, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 32, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 32, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 32, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 33, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 33, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 33, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 33, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 33, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 34, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 34, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 34, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 35, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 35, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 35, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 35, 6 });

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumns: new[] { "ProductId", "SpecificationId" },
                keyValues: new object[] { 35, 7 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
