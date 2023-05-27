# Good Recipes

A project by Alex Bennett (@ajbenn90) and Gavin Pease (@GT3CH1)

### Database ToDo's

#### User

- [ ] Email
    - Unique, not null
- [ ] Username
    - Unique, not null
- [ ] Suspended
    - Boolean, not null
- [ ] SuspendEndDate
    - Date, nullable
- [ ] Food Preferences
    - Array of strings, nullable
- [ ] Recipes
    - Array of Recipe IDs, nullable
- [ ] Favorite Recipes
    - Array of Recipe IDs, nullable
- [ ] Reviews
    - List of comments to recipe IDs
- [ ] Following Users
    - List of User ID's
- [ ] Comment/Post reports.

#### Recipe

- [ ] Name
- [ ] Thumbnail
- [ ] Author
- [ ] Sections
- [ ] Instructions
- [ ] Story
- [ ] Tags

#### Ingredient

- [ ] Name
- [ ] Categories
    - Such as animal-product, nut

#### Ingredient Categories

- [ ] List of different food categories.

#### Review

- [ ] Rating
- [ ] Text
- [ ] Recipe
- [ ] Author
- [ ] Helpful votes

#### Reports

- [ ] Type
- [ ] Reporter User
- [ ] Reported User
- [ ] Reported Content
- [ ] Reviewed
- [ ] Accepted
- [ ] Reviewed By
- [ ] Reviewed date

#### Recipe Ingredients

- [ ] Quantity
- [ ] Recipe
- [ ] Ingredient

Q: How do we want to represent this?

#### Review Vote

- [ ] Review
- [ ] User
- [ ] Helpfulness
