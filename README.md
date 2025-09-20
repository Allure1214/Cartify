# Cartify - Multi-Tenant E-Commerce SaaS Platform

Cartify is a comprehensive multi-tenant e-commerce platform built with ASP.NET Core 8.0, designed to help businesses launch and manage their online stores with powerful features and beautiful designs.

## 🚀 Features

### Platform-Level Features
- **Multi-Tenant Architecture**: Complete tenant isolation with subdomain/path-based routing
- **Tenant Onboarding**: Streamlined vendor sign-up and store creation
- **Subscription Management**: Flexible pricing plans with Stripe integration
- **Platform Analytics**: Comprehensive insights across all tenants
- **Tenant Management**: Admin dashboard for tenant oversight

### Tenant/Vendor Features
- **Store Management**: Custom branding, themes, and store configuration
- **Product Catalog**: Full CRUD operations with variants, categories, and inventory
- **Order Management**: Complete order lifecycle with status tracking
- **Payment Processing**: Stripe and PayPal integration
- **Customer Management**: Customer profiles and order history
- **Analytics Dashboard**: Sales insights and reporting

### Customer/Storefront Features
- **Responsive Storefront**: Mobile-first design with modern UI
- **Product Browsing**: Search, filter, and category navigation
- **Shopping Cart**: Full cart functionality with guest checkout
- **Secure Checkout**: Multiple payment options with order confirmation
- **Account Management**: Customer registration and order tracking

## 🏗️ Architecture

### Tech Stack
- **Backend**: ASP.NET Core 8.0 with Clean Architecture
- **Database**: SQL Server with Entity Framework Core
- **Frontend**: ASP.NET Core MVC with Bootstrap 5
- **Authentication**: ASP.NET Core Identity with JWT
- **Payments**: Stripe.NET SDK
- **Caching**: Redis
- **Logging**: Serilog
- **Email**: SendGrid

### Project Structure
```
Cartify/
├── src/
│   ├── Cartify.Platform/          # Main platform application
│   ├── Cartify.Domain/            # Domain entities and business logic
│   ├── Cartify.Application/       # Application services and CQRS
│   ├── Cartify.Infrastructure/    # Data access and external services
│   ├── Cartify.Storefront/        # Customer-facing storefront
│   └── Cartify.Admin/             # Tenant admin dashboard
├── docs/                          # Documentation
└── tests/                         # Unit and integration tests
```

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK
- SQL Server (LocalDB or full instance)
- Redis (optional, for caching)
- Visual Studio 2022 or VS Code

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-org/cartify.git
   cd cartify
   ```

2. **Update connection strings**
   - Update `appsettings.json` with your database connection string
   - Configure Stripe keys in `appsettings.json`

3. **Run database migrations**
   ```bash
   cd src/Cartify.Platform
   dotnet ef database update
   ```

4. **Run the application**
   ```bash
   dotnet run --project src/Cartify.Platform
   ```

5. **Access the application**
   - Platform: `https://localhost:7001`
   - Sample Store: `https://sample.localhost:7001`

## 🏢 Multi-Tenancy

Cartify implements a sophisticated multi-tenant architecture:

### Tenant Resolution
- **Subdomain-based**: `tenant1.cartify.com`
- **Path-based**: `cartify.com/tenant/tenant1`
- **Custom domains**: `store.example.com`

### Data Isolation
- Row-level security with TenantId filtering
- Complete data separation between tenants
- Shared platform data (subscriptions, plans)

### Tenant Features
- Custom branding and themes
- Isolated product catalogs
- Separate customer bases
- Independent order management

## 💳 Payment Integration

### Supported Payment Methods
- **Stripe**: Credit cards, digital wallets, bank transfers
- **PayPal**: PayPal payments and PayPal Credit
- **Cash on Delivery**: For local deliveries

### Subscription Billing
- Recurring subscription management
- Automatic billing and invoicing
- Proration for plan changes
- Dunning management for failed payments

## 🔐 Security

### Authentication & Authorization
- ASP.NET Core Identity
- Role-based access control (RBAC)
- JWT token authentication
- Multi-factor authentication support

### Data Protection
- Tenant data isolation
- Encrypted sensitive data
- Secure API endpoints
- GDPR compliance features

## 📊 Analytics & Reporting

### Platform Analytics
- Total tenants and revenue
- Subscription metrics
- Usage statistics
- Performance monitoring

### Tenant Analytics
- Sales and revenue tracking
- Product performance
- Customer insights
- Order analytics

## 🚀 Deployment

### Azure Deployment
1. Create Azure App Service
2. Configure SQL Database
3. Set up Redis Cache
4. Configure Application Insights
5. Deploy using Azure DevOps or GitHub Actions

### Docker Deployment
```bash
docker build -t cartify .
docker run -p 8080:80 cartify
```

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Add tests
5. Submit a pull request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🆘 Support

- Documentation: [docs.cartify.com](https://docs.cartify.com)
- Issues: [GitHub Issues](https://github.com/your-org/cartify/issues)
- Email: support@cartify.com

## 🗺️ Roadmap

- [ ] Mobile app for vendors
- [ ] Advanced analytics with ML
- [ ] Multi-language support
- [ ] Advanced inventory management
- [ ] Third-party integrations
- [ ] White-label solutions

---

Built with ❤️ using ASP.NET Core 8.0
