---
sidebar_position: 1
---

# Docusaurus

## Documents

For more detailed information, check out:

- [Official Docusaurus Documentation](https://docusaurus.io/docs)
- [Turtorial](https://www.youtube.com/watch?v=QfqLQwPxFWw&t=4696s)

## Quick Start

Install Docusaurus using Yarn:

```bash
yarn create docusaurus my-website classic
```

Navigate to your project:

```bash
cd my-website
```

Start the development server:

```bash
yarn start
```

## Project Structure

Key directories and files:

```
my-website/
├── blog/
├── docs/
├── src/
│   ├── components/
│   └── pages/
└── static/
    ├── docusaurus.config.js
    └── sidebars.js
```

## Basic Configuration

The main configuration file is `docusaurus.config.js`:

- [SampleConfig](./Scripts/Config.txt)

```javascript
module.exports = {
  title: "My Site",
  tagline: "Documentation made easy",
  url: "https://your-site.com",
  baseUrl: "/",
  // ... other configurations
};
```

## Custom Deployment

We can create a github action to deploy our website to github pages.

```
└── .github/
    └── workflows/
        └── deploy.yml
```

```yml
name: Deploy to GitHub Pages

on:
  push:
    branches:
      - main # Make sure this match the branch you want to deploy to

    # Review gh actions docs if you want to further define triggers, paths, etc
    # https://docs.github.com/en/actions/using-workflows/workflow-syntax-for-github-actions#on

permissions:
  contents: write

jobs:
  build:
    name: Deploy to GitHub Pages
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: actions/setup-node@v4
        with:
          node-version: 22
          cache: yarn

      - name: Install dependencies
        run: yarn install --frozen-lockfile
      - name: Build website
        run: yarn build

      - name: Upload Build Artifact
        uses: actions/upload-pages-artifact@v3
        with:
          path: build

  deploy:
    name: Deploy to GitHub Pages
    needs: build

    # Grant GITHUB_TOKEN the permissions required to make a Pages deployment
    permissions:
      pages: write # to deploy to Pages
      id-token: write # to verify the deployment originates from an appropriate source

    # Deploy to the github-pages environment
    environment:
      name: github-pages
      url: ${{ steps.deployment.outputs.page_url }}

    runs-on: ubuntu-latest
    steps:
      - name: Deploy to GitHub Pages
        id: deployment
        uses: actions/deploy-pages@v4
```

You should also update the `config.js`

```js
  // Set the production url of your site here
  url: "https://libiki123.github.io",
  // Set the /<baseUrl>/ pathname under which your site is served
  // For GitHub pages deployment, it is often '/<projectName>/'
  baseUrl: "/webdocs",

  // GitHub pages deployment config.
  // If you aren't using GitHub pages, you don't need these.
  organizationName: "libiki123", // Usually your GitHub org/user name.
  projectName: "webdocs", // Usually your repo name.
  deploymentBranch: "gh-pages",

```
