﻿// DroidEntity

// ReSharper disable BuiltInTypeReferenceStyle
// ReSharper disable RedundantNameQualifier
// ReSharper disable ArrangeObjectCreationWhenTypeEvident
// ReSharper disable UnusedType.Global
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable UnusedMethodReturnValue.Local
// ReSharper disable ConvertToAutoProperty
// ReSharper disable UnusedMember.Global
// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable InconsistentNaming
#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class DroidEntity
    {
        public global::System.String Name { get; set; } = default!;

        public global::System.String? PrimaryFunction { get; set; }

        public IGetHero_Hero_FriendsData? Friends { get; set; }
    }
}


// HumanEntity

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class HumanEntity
    {
        public global::System.String Name { get; set; } = default!;

        public global::System.String? HomePlanet { get; set; }

        public IGetHero_Hero_FriendsData? Friends { get; set; }
    }
}


// GetHeroFactory

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroFactory
        : global::StrawberryShake.IOperationResultDataFactory<GetHero>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid> _getHero_Hero_DroidFromDroidEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human> _getHero_Hero_HumanFromHumanEntityMapper;

        public GetHeroFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid> getHero_Hero_DroidFromDroidEntityMapper,
            global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human> getHero_Hero_HumanFromHumanEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getHero_Hero_DroidFromDroidEntityMapper = getHero_Hero_DroidFromDroidEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_DroidFromDroidEntityMapper));
            _getHero_Hero_HumanFromHumanEntityMapper = getHero_Hero_HumanFromHumanEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_HumanFromHumanEntityMapper));
        }

        public GetHero Create(global::StrawberryShake.IOperationResultDataInfo dataInfo)
        {
            if (dataInfo is GetHeroInfo info)
            {
                return new GetHero(MapIGetHero_Hero(info.Hero));
            }

            throw new global::System.ArgumentException("GetHeroInfo expected.");
        }

        private IGetHero_Hero? MapIGetHero_Hero(global::StrawberryShake.EntityId? entityId)
        {
            if (entityId is null || entityId == default)
            {
                return null;
            }


            if (entityId.Value.Name.Equals("Droid", global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_DroidFromDroidEntityMapper.Map(
                    _entityStore.GetEntity<DroidEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            if (entityId.Value.Name.Equals("Human", global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_HumanFromHumanEntityMapper.Map(
                    _entityStore.GetEntity<HumanEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetHeroInfo

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly ulong _version;

        public GetHeroInfo(
            global::StrawberryShake.EntityId? hero,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            ulong version)
        {
            Hero = hero;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::StrawberryShake.EntityId? Hero { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public ulong Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(ulong version)
        {
            return new GetHeroInfo(
                Hero,
                _entityIds,
                _version);
        }
    }
}


// GetHero

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero
        : IGetHero
    {
        public GetHero(IGetHero_Hero? hero)
        {
            Hero = hero;
        }

        public IGetHero_Hero? Hero { get; } = default!;
    }
}


// GetHero_Hero_DroidFromDroidEntityMapper

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_DroidFromDroidEntityMapper
        : global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Friends_Nodes_Droid> _getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Friends_Nodes_Human> _getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper;

        public GetHero_Hero_DroidFromDroidEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Friends_Nodes_Droid> getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper,
            global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Friends_Nodes_Human> getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper = getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper));
            _getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper = getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper));
        }

        public GetHero_Hero_Droid Map(DroidEntity entity)
        {
            return new GetHero_Hero_Droid(
                entity.Name,
                entity.PrimaryFunction,
                MapIGetHero_Hero_Friends(entity.Friends));
        }

        private IGetHero_Hero_Friends? MapIGetHero_Hero_Friends(IGetHero_Hero_FriendsData data)
        {
            if (data is null || data == default)
            {
                return null;
            }

            IGetHero_Hero_Friends returnValue = default!;

            if (data?.__typename.Equals("CharacterConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetHero_Hero_Friends_CharacterConnection(MapIGetHero_Hero_Friends_NodesArray(data.Nodes));
            }
            else {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<IGetHero_Hero_Friends_Nodes?>? MapIGetHero_Hero_Friends_NodesArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list)
        {
            if (list is null || list == default)
            {
                return null;
            }

            var iGetHero_Hero_Friends_Nodess = new global::System.Collections.Generic.List<IGetHero_Hero_Friends_Nodes?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                iGetHero_Hero_Friends_Nodess.Add(MapIGetHero_Hero_Friends_Nodes(child));
            }

            return iGetHero_Hero_Friends_Nodess;
        }

        private IGetHero_Hero_Friends_Nodes? MapIGetHero_Hero_Friends_Nodes(global::StrawberryShake.EntityId? entityId)
        {
            if (entityId is null || entityId == default)
            {
                return null;
            }


            if (entityId.Value.Name.Equals("Droid", global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper.Map(
                    _entityStore.GetEntity<DroidEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            if (entityId.Value.Name.Equals("Human", global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper.Map(
                    _entityStore.GetEntity<HumanEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetHero_Hero_Droid

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Droid
        : IGetHero_Hero_Droid
    {
        public GetHero_Hero_Droid(
            global::System.String name,
            global::System.String? primaryFunction,
            IGetHero_Hero_Friends? friends)
        {
            Name = name;
            PrimaryFunction = primaryFunction;
            Friends = friends;
        }

        public global::System.String Name { get; }

        public global::System.String? PrimaryFunction { get; } = default!;

        public IGetHero_Hero_Friends? Friends { get; } = default!;
    }
}


// GetHero_Hero_HumanFromHumanEntityMapper

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_HumanFromHumanEntityMapper
        : global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Friends_Nodes_Droid> _getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Friends_Nodes_Human> _getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper;

        public GetHero_Hero_HumanFromHumanEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Friends_Nodes_Droid> getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper,
            global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Friends_Nodes_Human> getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper = getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper));
            _getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper = getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper));
        }

        public GetHero_Hero_Human Map(HumanEntity entity)
        {
            return new GetHero_Hero_Human(
                entity.Name,
                entity.HomePlanet,
                MapIGetHero_Hero_Friends(entity.Friends));
        }

        private IGetHero_Hero_Friends? MapIGetHero_Hero_Friends(IGetHero_Hero_FriendsData data)
        {
            if (data is null || data == default)
            {
                return null;
            }

            IGetHero_Hero_Friends returnValue = default!;

            if (data?.__typename.Equals("CharacterConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetHero_Hero_Friends_CharacterConnection(MapIGetHero_Hero_Friends_NodesArray(data.Nodes));
            }
            else {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<IGetHero_Hero_Friends_Nodes?>? MapIGetHero_Hero_Friends_NodesArray(global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list)
        {
            if (list is null || list == default)
            {
                return null;
            }

            var iGetHero_Hero_Friends_Nodess = new global::System.Collections.Generic.List<IGetHero_Hero_Friends_Nodes?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                iGetHero_Hero_Friends_Nodess.Add(MapIGetHero_Hero_Friends_Nodes(child));
            }

            return iGetHero_Hero_Friends_Nodess;
        }

        private IGetHero_Hero_Friends_Nodes? MapIGetHero_Hero_Friends_Nodes(global::StrawberryShake.EntityId? entityId)
        {
            if (entityId is null || entityId == default)
            {
                return null;
            }


            if (entityId.Value.Name.Equals("Droid", global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper.Map(
                    _entityStore.GetEntity<DroidEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            if (entityId.Value.Name.Equals("Human", global::System.StringComparison.Ordinal))
            {
                return _getHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper.Map(
                    _entityStore.GetEntity<HumanEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetHero_Hero_Human

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Human
        : IGetHero_Hero_Human
    {
        public GetHero_Hero_Human(
            global::System.String name,
            global::System.String? homePlanet,
            IGetHero_Hero_Friends? friends)
        {
            Name = name;
            HomePlanet = homePlanet;
            Friends = friends;
        }

        public global::System.String Name { get; }

        public global::System.String? HomePlanet { get; } = default!;

        public IGetHero_Hero_Friends? Friends { get; } = default!;
    }
}


// GetHero_Hero_Friends_CharacterConnection

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Friends_CharacterConnection
        : IGetHero_Hero_Friends_CharacterConnection
    {
        public GetHero_Hero_Friends_CharacterConnection(global::System.Collections.Generic.IReadOnlyList<IGetHero_Hero_Friends_Nodes?>? nodes)
        {
            Nodes = nodes;
        }

        public global::System.Collections.Generic.IReadOnlyList<IGetHero_Hero_Friends_Nodes?>? Nodes { get; } = default!;
    }
}


// GetHero_Hero_Friends_CharacterConnectionData

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Friends_CharacterConnectionData
        : IGetHero_Hero_Friends_CharacterConnectionData
    {
        public GetHero_Hero_Friends_CharacterConnectionData(
            global::System.String typename,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? nodes)
        {
            __typename = typename
                 ?? throw new global::System.ArgumentNullException(nameof(typename));
            Nodes = nodes;
        }

        public global::System.String __typename { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Nodes { get; }
    }
}


// GetHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper
        : global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Friends_Nodes_Droid>
    {
        public GetHero_Hero_Friends_Nodes_Droid Map(DroidEntity entity)
        {
            return new GetHero_Hero_Friends_Nodes_Droid(entity.Name);
        }
    }
}


// GetHero_Hero_Friends_Nodes_Droid

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Friends_Nodes_Droid
        : IGetHero_Hero_Friends_Nodes_Droid
    {
        public GetHero_Hero_Friends_Nodes_Droid(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }
    }
}


// GetHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper
        : global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Friends_Nodes_Human>
    {
        public GetHero_Hero_Friends_Nodes_Human Map(HumanEntity entity)
        {
            return new GetHero_Hero_Friends_Nodes_Human(entity.Name);
        }
    }
}


// GetHero_Hero_Friends_Nodes_Human

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHero_Hero_Friends_Nodes_Human
        : IGetHero_Hero_Friends_Nodes_Human
    {
        public GetHero_Hero_Friends_Nodes_Human(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }
    }
}


// IGetHero

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero
    {
        public IGetHero_Hero? Hero { get; }
    }
}


// IHero

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IHero
    {
        public global::System.String Name { get; }

        public IGetHero_Hero_Friends? Friends { get; }
    }
}


// IGetHero_Hero

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero
        : IHero
    {
    }
}


// IDroid

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IDroid
    {
        public global::System.String? PrimaryFunction { get; }
    }
}


// IHero_Droid

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IHero_Droid
        : IDroid
    {
        public global::System.String Name { get; }

        public IGetHero_Hero_Friends? Friends { get; }
    }
}


// IGetHero_Hero_Droid

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero_Droid
        : IGetHero_Hero
        , IHero_Droid
    {
    }
}


// IHuman

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IHuman
    {
        public global::System.String? HomePlanet { get; }
    }
}


// IHero_Human

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IHero_Human
        : IHuman
    {
        public global::System.String Name { get; }

        public IGetHero_Hero_Friends? Friends { get; }
    }
}


// IGetHero_Hero_Human

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero_Human
        : IGetHero_Hero
        , IHero_Human
    {
    }
}


// IGetHero_Hero_Friends

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero_Friends
    {
        public global::System.Collections.Generic.IReadOnlyList<IGetHero_Hero_Friends_Nodes?>? Nodes { get; }
    }
}


// IGetHero_Hero_FriendsData

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero_FriendsData
    {
        public global::System.String __typename { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Nodes { get; }
    }
}


// IGetHero_Hero_Friends_CharacterConnection

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero_Friends_CharacterConnection
        : IGetHero_Hero_Friends
    {
    }
}


// IGetHero_Hero_Friends_CharacterConnectionData

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero_Friends_CharacterConnectionData
        : IGetHero_Hero_FriendsData
    {
        public global::System.String __typename { get; }
    }
}


// IGetHero_Hero_Friends_Nodes

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero_Friends_Nodes
    {
        public global::System.String Name { get; }
    }
}


// IGetHero_Hero_Friends_Nodes_Droid

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero_Friends_Nodes_Droid
        : IGetHero_Hero_Friends_Nodes
    {
    }
}


// IGetHero_Hero_Friends_Nodes_Human

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IGetHero_Hero_Friends_Nodes_Human
        : IGetHero_Hero_Friends_Nodes
    {
    }
}


// GetHeroQueryDocument

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroQueryDocument
        : global::StrawberryShake.IDocument
    {
        private const global::System.String _bodyString =
            @"query GetHero {
  hero(episode: NEW_HOPE) {
    __typename
    ... Hero
    ... on Droid {
      id
    }
    ... on Human {
      id
    }
  }
}

fragment Hero on Character {
  name
  ... Human
  ... Droid
  friends {
    __typename
    nodes {
      __typename
      name
      ... on Droid {
        id
      }
      ... on Human {
        id
      }
    }
  }
}

fragment Human on Human {
  homePlanet
}

fragment Droid on Droid {
  primaryFunction
}";
        private static readonly byte[] _body = global::System.Text.Encoding.UTF8.GetBytes(_bodyString);

        private GetHeroQueryDocument()
        {
        }

        public static GetHeroQueryDocument Instance { get; } = new GetHeroQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<byte> Body => _body;

        public override string ToString()
        {
            return _bodyString;
        }
    }
}


// GetHeroQuery

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetHero> _operationExecutor;

        public GetHeroQuery(global::StrawberryShake.IOperationExecutor<IGetHero> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetHero>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetHero>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return new global::StrawberryShake.OperationRequest(
                "GetHero",
                GetHeroQueryDocument.Instance);
        }
    }
}


// GetHeroBuilder

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetHeroBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, IGetHero>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> _extractId;
        private readonly global::StrawberryShake.IOperationResultDataFactory<IGetHero> _resultDataFactory;
        private global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;

        public GetHeroBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId> extractId,
            global::StrawberryShake.IOperationResultDataFactory<IGetHero> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _extractId = extractId
                 ?? throw new global::System.ArgumentNullException(nameof(extractId));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentNullException(nameof(_stringParser));
        }

        public global::StrawberryShake.IOperationResult<IGetHero> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetHero Result, GetHeroInfo Info)? data = null;

            if (response.Body is not null
                && response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement obj))
            {
                data = BuildData(obj);
            }

            return new global::StrawberryShake.OperationResult<IGetHero>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                null);
        }

        private (IGetHero, GetHeroInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            using global::StrawberryShake.IEntityUpdateSession session = _entityStore.BeginUpdate();
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();

            global::StrawberryShake.EntityId? heroId = UpdateIGetHero_HeroEntity(
                global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj, "hero"),
                entityIds);

            var resultInfo = new GetHeroInfo(
                heroId,
                entityIds,
                session.Version);

            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private global::StrawberryShake.EntityId? UpdateIGetHero_HeroEntity(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (obj is null || !obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _extractId(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals("Droid", global::System.StringComparison.Ordinal))
            {
                DroidEntity entity = _entityStore.GetOrCreate<DroidEntity>(entityId);
                entity.Name = DeserializeNonNullableString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "name"));
                entity.PrimaryFunction = DeserializeString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "primaryFunction"));
                entity.Friends = DeserializeIGetHero_Hero_Friends(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "friends"),
                    entityIds);

                return entityId;
            }

            if (entityId.Name.Equals("Human", global::System.StringComparison.Ordinal))
            {
                HumanEntity entity = _entityStore.GetOrCreate<HumanEntity>(entityId);
                entity.Name = DeserializeNonNullableString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "name"));
                entity.HomePlanet = DeserializeString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "homePlanet"));
                entity.Friends = DeserializeIGetHero_Hero_Friends(
                    global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "friends"),
                    entityIds);

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (obj is null || !obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (obj is null || !obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private IGetHero_Hero_FriendsData? DeserializeIGetHero_Hero_Friends(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value.GetProperty("__typename").GetString();

            if (typename.Equals("CharacterConnection", global::System.StringComparison.Ordinal))
            {
                return new GetHero_Hero_Friends_CharacterConnectionData(
                    typename,
                    UpdateIGetHero_Hero_Friends_NodesEntityArray(
                        global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "nodes"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetHero_Hero_Friends_NodesEntityArray(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (obj is null || !obj.HasValue)
            {
                return null;
            }

            var iGetHero_Hero_Friends_Nodess = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                iGetHero_Hero_Friends_Nodess.Add(UpdateIGetHero_Hero_Friends_NodesEntity(
                    child,
                    entityIds));
            }

            return iGetHero_Hero_Friends_Nodess;
        }

        private global::StrawberryShake.EntityId? UpdateIGetHero_Hero_Friends_NodesEntity(
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (obj is null || !obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _extractId(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals("Droid", global::System.StringComparison.Ordinal))
            {
                DroidEntity entity = _entityStore.GetOrCreate<DroidEntity>(entityId);
                entity.Name = DeserializeNonNullableString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "name"));

                return entityId;
            }

            if (entityId.Name.Equals("Human", global::System.StringComparison.Ordinal))
            {
                HumanEntity entity = _entityStore.GetOrCreate<HumanEntity>(entityId);
                entity.Name = DeserializeNonNullableString(global::StrawberryShake.Transport.Http.JsonElementExtensions.GetPropertyOrNull(obj.Value, "name"));

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }
    }
}


// FooClient

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class FooClient
    {
        private readonly GetHeroQuery _getHeroQuery;

        public FooClient(GetHeroQuery getHeroQuery)
        {
            _getHeroQuery = getHeroQuery
                 ?? throw new global::System.ArgumentNullException(nameof(getHeroQuery));
        }

        public GetHeroQuery GetHeroQuery => _getHeroQuery;
    }
}


// EntityIdFactory

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public static partial class EntityIdFactory
    {
        public static global::StrawberryShake.EntityId CreateEntityId(global::System.Text.Json.JsonElement obj)
        {
            global::System.String typeName = obj.GetProperty("__typename").GetString()!;

            return typeName switch
            {
                "Droid" => CreateDroidEntityId(obj, typeName),
                "Human" => CreateHumanEntityId(obj, typeName),
                _ => throw new global::System.NotSupportedException()
            };
        }

        private static global::StrawberryShake.EntityId CreateDroidEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj.GetProperty("id").GetString()!);
        }

        private static global::StrawberryShake.EntityId CreateHumanEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj.GetProperty("id").GetString()!);
        }
    }
}


// FooClientServiceCollectionExtensions

#nullable enable

namespace Foo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public static partial class FooClientServiceCollectionExtensions
    {
        public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddFooClient(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var serviceCollection = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();

            ConfigureClient(
                serviceCollection,
                strategy);

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => new ClientServiceProvider(sp));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<GetHeroQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<FooClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            return services;
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClient(
            global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {

            if (services is null)
            {
                throw new global::System.ArgumentNullException(nameof(services));
            }

            // register entity id factory

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::System.Func<global::System.Text.Json.JsonElement, global::StrawberryShake.EntityId>>(services, EntityIdFactory.CreateEntityId);

            // register stores

            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<
                global::StrawberryShake.IEntityStore,
                global::StrawberryShake.EntityStore>(
                    services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<
                global::StrawberryShake.IOperationStore>(
                    services,
                    sp => new global::StrawberryShake.OperationStore(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<
                            global::StrawberryShake.IEntityStore
                            >(sp)
                        .Watch()
                        ));

            // register connections

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp =>
                {
                    var clientFactory =
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<
                            global::System.Net.Http.IHttpClientFactory
                            >(sp);

                    return new global::StrawberryShake.Transport.Http.HttpConnection(
                        () => clientFactory.CreateClient("FooClient"));
                });

            // register mappers

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Droid>, GetHero_Hero_DroidFromDroidEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Human>, GetHero_Hero_HumanFromHumanEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<DroidEntity, GetHero_Hero_Friends_Nodes_Droid>, GetHero_Hero_Friends_Nodes_DroidFromDroidEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<HumanEntity, GetHero_Hero_Friends_Nodes_Human>, GetHero_Hero_Friends_Nodes_HumanFromHumanEntityMapper>(services);

            // register serializers

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UuidSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver, global::StrawberryShake.Serialization.SerializerResolver>(services);

            // register operations

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                global::StrawberryShake.IOperationResultDataFactory<IGetHero>,
                GetHeroFactory>(
                    services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, IGetHero>,
                GetHeroBuilder>(
                    services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                global::StrawberryShake.IOperationExecutor<IGetHero>>(
                    services,
                    sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, IGetHero>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                        () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, IGetHero>>(sp),
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                        strategy));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<GetHeroQuery>(services);

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<FooClient>(services);

            return services;
        }

        private class ClientServiceProvider
            : System.IServiceProvider
            , System.IDisposable
        {
            private readonly System.IServiceProvider _provider;

            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}


