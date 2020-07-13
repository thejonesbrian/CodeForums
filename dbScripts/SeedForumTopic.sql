SELECT * FROM Forums

INSERT INTO Forums (Created, Title, [Description], ImageUrl)
VALUES
(GETDATE(), 'Python', 'Python is a popular strongly-typed general programming language.', '/images/forum/python.png'),
(GETDATE(), 'C#', 'C# popular for creating .Net Framework applications.', '/images/forum/csharp.png'),
(GETDATE(), 'Go', 'Open Source programming language', '/images/forum/go.png'),
(GETDATE(), 'Javascript', 'Javascript is a popular language for adding dynamic functionality to websites.', '/images/forum/js.png'),
(GETDATE(), 'Flutter', 'Popular for making dynamic responsive applications on webpages or mobile.', '/images/forum/flutter.png')