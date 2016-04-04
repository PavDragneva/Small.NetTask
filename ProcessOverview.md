# Small.NetTask
<h2>Process overview</h2>
<p>
I started the project by creating the database. As an approach I used code first, because it’s more intuitive and for me it’s easier to look at the base tables in terms of regular classes.
</p>
<p>
For the architecture I decided to use repository pattern and service layer. The service layer make the code in the controllers shorter, easier to read and more organized. Also it gave an additional level of abstraction. For the Views, I used master page but it would be helpful If there was more than one page with common elements. In my app, there is only one page and one partial view, but still it seems more correctly to have a master page.
</p>
<p>
For the information of the users, which is displayed on the main page, I created a custom view model. It was needed because otherwise personal information like passwords can be easily accessed. Also I used bundling, because it decreases the number of requests and optimizes the performance of the app.
</p>
<p>
This was my first project combining Web Api with MVC and it took me a while to gain knowledge how the things should match together. I had some issues like using the correct ninject and some other of that kind. 
</p>
<strong>Connection string – “.”</strong>
<br/>
<strong>Name of the database – SmallProject</strong>
<br/>
<br/>
<strong>Routes</strong>
<br/>
/User/Index – returns list of all the users, who aren’t with status ‘Deleted’
<br/>
<br/>
WebApi Services - PUT
<br/>
/api/apiuser/DeleteUser/{id} - changes the status of the user to ‘Deleted’
<br/>
/api/apiuser/UpdateStatus/{id} - changes the status of the user from ‘Active’ to ‘Inactive’ and vice-versa
<br/>
<br/>
<strong>Approximate time:</strong> 11 - 12 hours
<br/>
<br/>
<strong>Main Resources:</strong>
<br/>
1.	http://stackoverflow.com/questions/22146823/asp-net-mvc-using-web-api-to-return-a-razor-view
<br/>
2.	http://www.mikesdotnetting.com/article/261/integrating-web-api-with-asp-net-razor-web-pages
<br/>
3.	http://stackoverflow.com/questions/21934223/web-api-2-routing-the-resource-cannot-be-found



