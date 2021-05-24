# Valocity Technical Assessment

This is your chance to shine and show off all your `ski11z`. We suggest you spend no more than **90 minutes** to get through as much as you can. It is up to you to manage your time. The answers will be assessed against the role you have applied for so ensure you demonstrate the key objectives expected by the role.

## Getting started

You will need [git](https://git-scm.com/) and a code editor of your choice. We recommend [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/).
If you are hoping to cut code you will need to follow your nose to setup a development environment, or you can use a [Remote development container](https://code.visualstudio.com/docs/remote/containers-tutorial).
Once this workspace has re-opened in the remote container run the following commands to ensure you are setup and ready to go.

```bash
dotnet restore
dotnet build
dotnet test
```

## Submitting

**Commit** to the local git repo **often** to show progress and workflow. Ensure the comments explain **why** you did the change.

To submit your solution:

 1. Ensure you have committed all your changes
 1. Run `git clean -xdf` to clear our any build artifacts
 1. Compress the solution source into a single archive
    - > ⚠ Ensure the .git folder is included in the archive
 1. Send on through!

### Exercise 1: Code Review

This will asses your knowledge of clean code and ability to critique code.
The code in [CodeToReview.cs](CodeToReview.cs) has been submitted by an intern from another team to a code base you depend on. Using inline comments, review the code with enough context for the author to learn and enhance the code.

### Exercise 2: Working with legacy code

This will asses your ability to refactor code.
Open the [CodingAssessment solution](./CodingAssessment.sln) and improve the code base. Use comments, commit messages and automated tests to express your reasoning, assumptions and issues encountered.

### Exercise 3: Clean green fields project

This will asses your ability to 

- design solutions
- decompose problems
- knowledge of clean architecture
- knowledge of continuos delivery 

> As an enthusiastic card player and developer
I want to create a program to play cards against the computer
So that when I am bored I can play against an intelligent opponent.

Constraints:
- unsure of what UI to build for, or what card game I should code for (I'll figure that out later).

At this stage I know I need a concept of a Deck, Cards and a Shuffle function.

How would you setup your new solution and why? 

- Show me your initial to do list with some reasoning, for example:
  - Development environment setup
  - Scaffold / structure of your solution
  - What would your delivery pipeline look like
- Scaffold your solution
  - See how much you can scaffold out to hand to another team member to continue with
  - Bonus points if you have something working
