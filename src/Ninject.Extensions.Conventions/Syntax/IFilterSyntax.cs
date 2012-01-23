//-------------------------------------------------------------------------------
// <copyright file="IFilterSyntax.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2011 Ninject Project Contributors
//   Authors: Remo Gloor (remo.gloor@gmail.com)
//           
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   you may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Ninject.Extensions.Conventions.Syntax
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Syntax for the selection of the types.
    /// </summary>
    public interface IFilterSyntax
    {
        /// <summary>
        /// Selects the types in the specified namespaces.
        /// </summary>
        /// <param name="namespaces">The namespaces from which the types are selected.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax InNamespaces(IEnumerable<string> namespaces);

        /// <summary>
        /// Selects the types in the specified namespaces.
        /// </summary>
        /// <param name="namespaces">The namespaces from which the types are selected.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax InNamespaces(params string[] namespaces);

        /// <summary>
        /// Selects the types in the same namespace as the given type.
        /// </summary>
        /// <typeparam name="T">The type defining the namespace.</typeparam>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax InNamespaceOf<T>();

        /// <summary>
        /// Selects the types in the same namespaces as the given types.
        /// </summary>
        /// <param name="types">The types defining the namespaces.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax InNamespaceOf(params Type[] types);

        /// <summary>
        /// Selects all types not in the given namespaces.
        /// </summary>
        /// <param name="namespaces">The namespaces from which the types are not selected.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax NotInNamespaces(IEnumerable<string> namespaces);

        /// <summary>
        /// Selects all types not in the given namespaces.
        /// </summary>
        /// <param name="namespaces">The namespaces from which the types are not selected.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax NotInNamespaces(params string[] namespaces);

        /// <summary>
        /// Selects all types not in same namespaces as the given type.
        /// </summary>
        /// <typeparam name="T">The type defining the namespace.</typeparam>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax NotInNamespaceOf<T>();

        /// <summary>
        /// Selects all types not in same namespaces as the given types.
        /// </summary>
        /// <param name="types">The types defining the namespace.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax NotInNamespaceOf(params Type[] types);

        /// <summary>
        /// Selects the types inherited from any of the given types.
        /// </summary>
        /// <param name="types">The ancestor types.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax InheritedFromAny(IEnumerable<Type> types);

        /// <summary>
        /// Selects the types inherited from any of the given types.
        /// </summary>
        /// <param name="types">The ancestor types.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax InheritedFromAny(params Type[] types);

        /// <summary>
        /// Selects the types inherited from the given types.
        /// </summary>
        /// <param name="type">The ancestor type.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax InheritedFrom(Type type);

        /// <summary>
        /// Selects the types inherited from the given types.
        /// </summary>
        /// <typeparam name="T">The ancestor type.</typeparam>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax InheritedFrom<T>();

        /// <summary>
        /// Selects the types with the specified attribute.
        /// </summary>
        /// <typeparam name="T">The type of the attribute</typeparam>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax WithAttribute<T>()
            where T : Attribute;

        /// <summary>
        /// Selects the types that matches the specified attribute predicate.
        /// </summary>
        /// <typeparam name="T">The type of the attribute</typeparam>
        /// <param name="predicate">A function to test if an attribute matches.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax WithAttribute<T>(Func<T, bool> predicate)
            where T : Attribute;

        /// <summary>
        /// Selects the types with the specified attribute.
        /// </summary>
        /// <param name="attributeType">The type of the attribute.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax WithAttribute(Type attributeType);

        /// <summary>
        /// Selects the types without the specified attribute.
        /// </summary>
        /// <typeparam name="T">The type of the attribute</typeparam>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax WithoutAttribute<T>()
            where T : Attribute;

        /// <summary>
        /// Selects the types that do not match the specified attribute predicate.
        /// </summary>
        /// <typeparam name="T">The type of the attribute</typeparam>
        /// <param name="predicate">A function to test if an attribute matches.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax WithoutAttribute<T>(Func<T, bool> predicate)
            where T : Attribute;

        /// <summary>
        /// Selects the types without the specified attribute.
        /// </summary>
        /// <param name="attributeType">The type of the attribute.</param>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax WithoutAttribute(Type attributeType);

        /// <summary>
        /// Selects the types that are generic.
        /// </summary>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax WhichAreGeneric();

        /// <summary>
        /// Selects the types that are not generic.
        /// </summary>
        /// <returns>The fluent syntax</returns>
        IFromFilterWhereExcludeIncludeBindSyntax WhichAreNotGeneric();
    }
}