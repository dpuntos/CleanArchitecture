# CleanArchitecture
A C# Blazor Web Application developed using a Clean Architecture concept.
## Description
To achieve this result, I have followed this post: [Common web application architectures](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures) as a guide.
<br>With this example, you can see how to easily create a basic approach to this type of architecture.  It doesn't cover all scenarios, but for many cases, it is more than enough.
<br>This architecture, however simple it may be, offers a lot of advantages, all of which are described in the referenced article above.
<br>
In summary, the idea is to structure the code as follows:
<br>

## Diagram
<p align="center">
  <img src="../master/Diagram.png">
</p>

As you can see, Web Application is completely unaware of the implementation of the interfaces. These implementations are obtained through a dependency container.
So, the web application is not affected in case the implementation changes.
<br>
However, there's another notable feature to highlight. This architecture allows for the addition of a unit testing layer that is also independent of the interface implementations.

## Diagram with Unit Testing Layer
<p align="center">
  <img src="../master/DiagramUT.png">
</p>
Indeed, you could use the entire implementation layer in other kinds of applications, not only for unit tests but also, for example, in desktop or mobile applications.
