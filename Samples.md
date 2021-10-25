# Samples 
For ways of binding the `FreshworksApi` to the application check this [File](./Binding.md).  

## `Account Types:`
```csharp
// Include
var output = await client.Account.Include(string include);

// Insert
var output = await client.Account.Insert(Account);

// Get by id
var output = await client.Account.GetByID(Account);
var output = await client.Account.GetByID<Account>(long id);

// Get all by id
var output = await client.Account.GetAllByID(Account);
var output = await client.Account.GetAllByID<Account>(long id);

// Update
var output = await client.Account.Update(Account);

// Clone
var output = await client.Account.Clone(Account);

// Delete
var output = await client.Account.Delete(Account);
var output = await client.Account.Delete<Account>(long id);

// Forget
var output = await client.Account.Forget(Account);
var output = await client.Account.Forget<Account>(long id);

// Bulk Delete
var output = await client.Account.DeleteBulk(Account);

// Get All Fields
var output = await client.Account.GetAllFields<Account>();

// Get All Filters
var output = await client.Account.FetchAll<Account>();
```

## `Appointment Types:`
```csharp
// Include
var output = await client.Appointment.Include(string include);

// Add Filters parameter
var output = await client.Appointment.GetAllByFilter<Appointment>(string filter);

// Insert
var output = await client.Appointment.Insert(Appointment);

// Get by id
var output = await client.Appointment.GetByID(Appointment);
var output = await client.Appointment.GetByID<Appointment>(long id);

// Get all by id
var output = await client.Appointment.GetAllByID(Appointment);
var output = await client.Appointment.GetAllByID<Appointment>(long id);

// Update
var output = await client.Appointment.Update(Appointment);

// Delete
var output = await client.Appointment.Delete(Appointment);
var output = await client.Appointment.Delete<Appointment>(long id);

// Get All Fields
var output = await client.Appointment.GetAllFields<Appointment>();

// Get All Filters
var output = await client.Appointment.FetchAll<Appointment>();
```

## `Contact Types:`
```csharp
// Include
var output = await client.Contact.Include(string include);

// Insert
var output = await client.Contact.Insert(Contact);

// Get by id
var output = await client.Contact.GetByID(Contact);
var output = await client.Contact.GetByID<Contact>(long id);

// Get all by id
var output = await client.Contact.GetAllByID(Contact);
var output = await client.Contact.GetAllByID<Contact>(long id);

// Update
var output = await client.Contact.Update(Contact);

// Clone
var output = await client.Contact.Clone(Contact);

// Delete
var output = await client.Contact.Delete(Contact);
var output = await client.Contact.Delete<Contact>(long id);

// Forget
var output = await client.Contact.Forget(Contact);
var output = await client.Contact.Forget<Contact>(long id);

// Assign Bulk
var output = await client.Contact.AssignBulk(Contact);

// Delete Bulk
var output = await client.Contact.DeleteBulk(Contact);

// Get All Activities
var output = await client.Contact.GetAllActivitiesByID(Contact);
var output = await client.Contact.GetAllActivitiesByID<Contact>(long id);

// Get All Fields
var output = await client.Contact.GetAllFields<Contact>();

// Get All Filters
var output = await client.Contact.FetchAll<Contact>();
```

## `Deal Types:`
```csharp
// Include
var output = await client.Deal.Include(string include);

// Insert
var output = await client.Deal.Insert(Deal);

// Get by id
var output = await client.Deal.GetByID(Deal);
var output = await client.Deal.GetByID<Deal>(long id);

// Get all by id
var output = await client.Deal.GetAllByID(Deal);
var output = await client.Deal.GetAllByID<Deal>(long id);

// Update
var output = await client.Deal.Update(Deal);

// Clone
var output = await client.Deal.Clone(Deal);

// Delete
var output = await client.Deal.Delete(Deal);
var output = await client.Deal.Delete<Deal>(long id);

// Forget
var output = await client.Deal.Forget(Deal);
var output = await client.Deal.Forget<Deal>(long id);

// Delete Bulk
var output = await client.Deal.DeleteBulk(Deal);

// Get All Fields
var output = await client.Deal.GetAllFields<Deal>();

// Get All Filters
var output = await client.Deal.FetchAll<Deal>();
```

## `File Types:`
```csharp
// Include
var output = await client.File.Include(string include);

// Insert
var output = await client.File.Insert(File);
var output = await client.File.InsertForm(File);

// Get activities on ID
var output = await client.File.GetAllActivitiesByID(Deal);
var output = await client.File.GetAllActivitiesByID<Deal>(long id);

// Get All Filters
var output = await client.Deal.FetchAll<Deal>();
```


## `Note Types:`
```csharp
// Insert
var output = await client.Note.Insert(Note);

// Update
var output = await client.Note.Update(Deal);

// Delete
var output = await client.Note.Delete(Note);
var output = await client.Note.Delete<Note>(long id);
```

## `Phone Types:`
```csharp
// Insert
var output = await client.Phone.Insert(Phone);
```

## `Sale Types:`
```csharp
// Include
var output = await client.Sale.Include(string include);

// Add Filters
var output = await client.Sale.GetAllByFilter<Sale>(string filter);

// Get All Filters
var output = await client.Deal.FetchAll<Deal>();

// Insert
var output = await client.Sale.Insert(Sale);

// Get by ID
var output = await client.Sale.GetByID(Sale);
var output = await client.Sale.GetByID<Sale>(long id);

// Get all by ID
var output = await client.Sale.GetAllByID(Sale);
var output = await client.Sale.GetAllByID<Sale>(long id);

// Update
var output = await client.Sale.Update(Sale);

// Delete
var output = await client.Sale.Delete(Sale);
var output = await client.Sale.Delete<Sale>(long id);
```








## `Search Types:`
```csharp
// Include
var output = await client.Search.Include(string include);

// get content that contains the query
var output = await client.Search.SearchOnQuery(string query);

// get content that contains the query
var output = await client.Search.SearchOnQuery(string query);

// get content that is valid on the SearchFilter
var output = await client.Search.SearchOnFilter<where Model: IHasFilteredSearch>(SearchFilter filters);

// get content that contains the query
var output = await client.Search.SearchOnLookup(string query, string field, string entities);
```


## `Task Types:`
```csharp
// Include
var output = await client.Task.Include(string include);

// Get All Filters
var output = await client.Contact.FetchAll<Contact>();

// Insert
var output = await client.Task.Insert(Task);

// Get by id
var output = await client.Task.GetByID(Task);
var output = await client.Task.GetByID<Task>(long id);

// Get all by id
var output = await client.Task.GetAllByID(Task);
var output = await client.Task.GetAllByID<Task>(long id);

// Update
var output = await client.Task.Update(Task);

// Mark Task as Done
// "task": {
//     "status": 1
// }
var output = await client.Task.Update(Task);

// Delete
var output = await client.Task.Delete(Task);
var output = await client.Task.Delete<Task>(long id);
```


## `Selector Types:`
```csharp
// Get all Sales activity types
var output = client.Selector.GetSalesActivityTypes();

// Get all sales activity entity types
var output = client.Selector.GetSalesActivityEntityTypes();

// Get all sales activity outcomes
var output = client.Selector.GetSalesActivityOutcomes();

// Get all sales activity outcomes by ID
var output = client.Selector.GetSalesActivityOutcomesByID(long id);

// Get all deal products
var output = client.Selector.GetDealProducts();

// Get all deal stages
var output = client.Selector.GetDealStages();

// Get all deal types
var output = client.Selector.GetDealTypes();

// Get all deal reasons
var output = client.Selector.GetDealReasons();

// Get all deal pipelines
var output = client.Selector.GetDealPipelines();

// Get all deal pipelines on ID 
var output = client.Selector.GetDealPipelinesByID(long id);

// Get all deals with payment statuses
var output = client.Selector.GetDealPaymentStatuses();

// Get all teritories
var output = client.Selector.GetTerritories();

// Get all campaigns
var output = client.Selector.GetCampaigns();

// Get all owners
var output = client.Selector.GetOwners();

// Get all currencies
var output = client.Selector.GetCurrencies();

// Get all contact statuses
var output = client.Selector.GetContactStatuses();

// Get all business types
var output = client.Selector.GetBusinessTypes();

// Get all sales activity outcomes
var output = client.Selector.GetLifecycleStages();

// Get all industry types
var output = client.Selector.GetIndustryTypes();
```

## Query

Query You can call them